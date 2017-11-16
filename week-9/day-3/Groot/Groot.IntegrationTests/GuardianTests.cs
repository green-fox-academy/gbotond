using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Groot.IntegrationTests
{
    public class GuardianTests
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTests()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnNotFound()
        {
            var response = await Client.GetAsync("/groot");

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            var response = await Client.GetAsync("/groot?message=test");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ExpectedResponseIAmGroot()
        {
            string test = await Client.GetStringAsync("/groot?message=test");

            Assert.Equal("{\"received\":\"test\",\"translated\":\"I am Groot!\"}", test);
        }

        [Fact]
        public async Task ReturnExpectedResponse()
        {
            var response = await Client.GetAsync("/groot/message");

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"received\":\"message\",\"translated\":\"I am Groot!\"}", responseJson);
        }

        [Fact]
        public async Task ReturnExpectedResponseWithoutMessage()
        {
            var response = await Client.GetAsync("/groot");

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"I am Groot!\"}", responseJson);
        }

    }
}

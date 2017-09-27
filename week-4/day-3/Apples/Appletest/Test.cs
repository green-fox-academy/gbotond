using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apples;
using NUnit.Framework;

namespace Appletest
{
    [TestFixture]
    public class Test   
    {
        Apple apple = new Apple();

        [Test]
        public void TestGetApple()
        {
            string message = "apple";

            Assert.AreEqual(message, apple.GetApple());
        }
    }
}

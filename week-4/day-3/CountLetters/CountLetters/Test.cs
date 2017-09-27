using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountLetters;
using NUnit.Framework;

namespace CountLetters
{
    [TestFixture]
    public class Test
    {
        Counter counter = new Counter();

        [Test]
        public void TestDictionary()
        {
            string input = "information";

            Dictionary<char, int> testDict = new Dictionary<char, int>()
            {
                { 'i', 2 },
                { 'n', 2 },
                { 'f', 1 },
                { 'o', 2 },
                { 'r', 1 },
                { 'm', 1 },
                { 'a', 1 },
                { 't', 1 }
            };

            Assert.AreEqual(testDict, counter.StrToDictCount(input));
        }
    }
}

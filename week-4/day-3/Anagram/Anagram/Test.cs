using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;
using NUnit.Framework;

namespace Anagram
{
    [TestFixture]
    public class Test
    {
        AnagramClass anagram = new AnagramClass();

        [Test]
        public void TestAnagrams()
        {
            string first = "team";
            string second = "meat";

            bool output = true;

            Assert.AreEqual(output, AnagramClass.AnagramOrNot(first, second));
        }

        [Test]
        public void NotAnagram()
        {
            string first = "team";
            string second = "greenfox";

            bool output = false;

            Assert.AreEqual(output, AnagramClass.AnagramOrNot(first, second));
        }

        [Test]
        public void TestLonger()
        {
            string first = "team";
            string second = "meeat";

            bool output = false;

            Assert.AreEqual(output, AnagramClass.AnagramOrNot(first, second));
        }

        [Test]
        public void TestUpperCase()
        {
            string first = "team";
            string second = "mEaT";

            bool output = false;

            Assert.AreEqual(output, AnagramClass.AnagramOrNot(first, second));
        }
    }
}

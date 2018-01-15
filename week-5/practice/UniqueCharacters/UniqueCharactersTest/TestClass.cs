using NUnit.Framework;
using System;
using System.Collections.Generic;
using UniqueCharacters;

namespace UniqueCharactersTest
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestUniqueCharactersWhenSingleLetter()
        {
            string input = "a";
            var output = new List<char> { 'a' };

            Assert.AreEqual(output, UniqueCharacters.UniqueCharacters.GetUniqueCharacters(input));
        }

        [Test]
        public void TestUniqueCharactersWhenSameLetterMultipleTimes()
        {
            string input = "bbbbb";
            var output = new List<char> { 'b' };

            Assert.AreEqual(output, UniqueCharacters.UniqueCharacters.GetUniqueCharacters(input));
        }

        [Test]
        public void TestUniqueCharactersWhenUniqLettersSingleTime()
        {
            string input = "abc";
            var output = new List<char> { 'a', 'b', 'c' };

            Assert.AreEqual(output, UniqueCharacters.UniqueCharacters.GetUniqueCharacters(input));
        }

        [Test]
        public void TestUniqueCharactersWhenUniqLettersMultipleTimes()
        {
            string input = "accabccbbaaacaabba";
            var output = new List<char> { 'a', 'c', 'b' };

            Assert.AreEqual(output, UniqueCharacters.UniqueCharacters.GetUniqueCharacters(input));
        }


        [Test]
        public void TestUniqueCharactersWhenUniqLettersMultipleTimesUpperLowerCases()
        {
            string input = "AccabccbBaaaCaabba";
            var output = new List<char> { 'a', 'c', 'b' };

            Assert.AreEqual(output, UniqueCharacters.UniqueCharacters.GetUniqueCharacters(input));
        }
    }
}

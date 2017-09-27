using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum;
using NUnit.Framework;

namespace SumTest
{
    [TestFixture]
    public class Test
    {
        SumClass sumlist = new SumClass();

        [Test]
        public void TestEmptySumList()
        {
            var emptyList = new List<int>();
            int output = 0;

            Assert.AreEqual(output, sumlist.SumList(emptyList));
        }

        [Test]
        public void TestSingleSumlist()
        {
            var oneElementList = new List<int> { 8 };
            int output = 8;

            Assert.AreEqual(output, sumlist.SumList(oneElementList));
        }

        [Test]
        public void TestMultipleSumList()
        {
            var multiElementList = new List<int> { 1, 2, 3, 4, 5 };
            int output = 15;

            Assert.AreEqual(output, sumlist.SumList(multiElementList));
        }

        [Test]
        public void TestNullSumList()
        {
            int output = 5;

            Assert.AreEqual(output, sumlist.SumList(null));
        }
    }
}

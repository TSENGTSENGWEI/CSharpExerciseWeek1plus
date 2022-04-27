using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class TestSortArraryTests
    {
        [TestMethod()]
        public void SortArrayTest()
        {
            var expect = new int[] { 1, 2, 3, 4, 5 };

            var actual = new TestSortArrary().SortArray(new int[] { 5, 4, 3, 2, 1 });

            for (int index = 0; index < actual.Length; index++)
            {
                Assert.AreEqual(expect[index], actual[index]);
            }
        }
    }
}
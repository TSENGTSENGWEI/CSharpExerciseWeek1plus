using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class TestSingleTests
    {
        [TestMethod()]
        public void SingleNumberTest()
        {
            var expect = 1;

            var actual = new TestSingle().SingleNumber(new int[] { 2, 2, 1 });

            Assert.AreEqual(expect, actual);

            expect = 4;

            actual = new TestSingle().SingleNumber(new int[] { 4, 1, 2, 1, 2 });

            Assert.AreEqual(expect, actual);

            expect = 1;

            actual = new TestSingle().SingleNumber(new int[] { 1 });

            Assert.AreEqual(expect, actual);
        }
    }
}
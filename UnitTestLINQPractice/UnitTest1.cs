using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LINQPractice.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIncrement()
        {
            var subject = new List<int> { 0, 1, 2, 3 };

            var expected = new List<int> { 1, 2, 3, 4 };

            var actual = LINQPractice.Program.Increment(subject);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetDivisible()
        {
            var subject = new List<int> { 0, 1, 2, 3 };

            var expected = new int[] { 0, 2 };

            var actual = LINQPractice.Program.GetWhereDivisible(subject, 2);

            CollectionAssert.AreEqual(expected, actual);
        }
        }
}

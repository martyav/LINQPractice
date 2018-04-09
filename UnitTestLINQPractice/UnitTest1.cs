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

        [TestMethod]
        public void TestAnyCaps()
        {
            var subject1 = "Hello, world";
            var subject2 = "hello, world";

            var actual1 = LINQPractice.Program.AnyCapitals(subject1);
            var actual2 = LINQPractice.Program.AnyCapitals(subject2);

            Assert.IsTrue(actual1);
            Assert.IsFalse(actual2);
        }

        [TestMethod]
        public void TestAllCaps()
        {
            var subject1 = "Hello, world";
            var subject2 = "HELLLLLLLLLLLLLLOOOOOOOOOOO";

            var actual1 = LINQPractice.Program.AllCapitals(subject1);
            var actual2 = LINQPractice.Program.AllCapitals(subject2);

            Assert.IsFalse(actual1);
            Assert.IsTrue(actual2);
        }

        [TestMethod]
        public void TestFindFirstArrayWithLength()
        {
            var array1 = new int[] { 1, 2, 3 };
            var array2 = new int[] { 1, 2, 3, 4 };
            var array3 = new int[] { 1 };
            var array4 = new int[] { 1, 2, 3 };
            var array5 = new int[] { 1, 2, 3, 4, 5 };

            var subject1 = new List<int[]> { array1, array2, array3, array4, array5 };

            var expected1 = array2;
            int[] expected2 = null;

            var actual1 = LINQPractice.Program.FindFirstArrayWithLength(subject1, 3);
            var actual2 = LINQPractice.Program.FindFirstArrayWithLength(subject1, 3_000);

            CollectionAssert.AreEqual(expected1, actual1);
            CollectionAssert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void TestGetLastOddElement()
        {
            var subject1 = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            var subject2 = new int[] { 2, 4, 6, 8 };

            var expected1 = 5;
            int expected2 = 0;

            var actual1 = LINQPractice.Program.GetLastOddElement(subject1);
            var actual2 = LINQPractice.Program.GetLastOddElement(subject2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}

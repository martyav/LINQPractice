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

        [TestMethod]
        public void TestGetMinListListValue()
        {
            var list1 = new List<int> { 1, 2, 3 };
            var list2 = new List<int> { 2, 3, 4 };
            var list3 = new List<int> { 100 };
            var list4 = new List<int> { 3 };
            var list5 = new List<int> { 4, 5 };

            var subject = new List<List<int>> { list1, list2, list3, list4, list5 };

            var expected = 1;

            var actual = LINQPractice.Program.GetMinListListValue(subject);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetMaxStringLength()
        {
            var subject = new List<String> { "a", "abc", "sadf", "crazy" };

            var expected = 5;

            var actual = LINQPractice.Program.GetMaxStringLength(subject);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOrder()
        {
            var user1 = new User();
            var user2 = new User();
            var user3 = new User();
            var user4 = new User();

            user1.Age = 60;
            user1.FirstName = "A.";
            user1.LastName = "Redmond";

            user2.Age = 60;
            user2.FirstName = "B.";
            user2.LastName = "Bedmond";

            user3.Age = 69;
            user3.FirstName = "C.";
            user3.LastName = "Tedmond";

            user4.Age = 64;
            user4.FirstName = "D.";
            user4.LastName = "Dedmond";

            var subject = new List<User> { user1, user2, user3, user4 };

            var expected = new List<User> { user3, user4, user2, user1 };

            var actual = LINQPractice.Program.sortUsersByAge(subject);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}

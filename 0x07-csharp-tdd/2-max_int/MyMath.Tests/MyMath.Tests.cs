using NUnit.Framework;
using System.Collections.Generic;


namespace MyMath.Tests
{
    public class OpTests
    {
        [Test]
        public void IsCorrect()
        {
            List<int> newList = new List<int>() {1, 2, 3, 4, 5, 6};

            int result = MyMath.Operations.Max(newList);
            int expected = 6;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void BigNums()
        {
            List<int> newList = new List<int>() {100000, 200000, 300000, 400000, 500000, 600000};

            int result = MyMath.Operations.Max(newList);
            int expected = 600000;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void NegativeNums()
        {
            List<int> newList = new List<int>() {-1, -2, -3, -4, -5, -6};

            int result = MyMath.Operations.Max(newList);
            int expected = -1;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CombinedPositiveAndNegativeNums()
        {
            List<int> newList = new List<int>() {-1, 2, -3, -4, 5, -6};

            int result = MyMath.Operations.Max(newList);
            int expected = 5;

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ElementsAreZero()
        {
            List<int> newList = new List<int>() {0, 0, 0, 0, 0, 0};

            int result = MyMath.Operations.Max(newList);
            int expected = 0;

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void IfListEmpty()
        {
            List<int> newList = new List<int>() {};

            int result = MyMath.Operations.Max(newList);
            int expected = 0;

            Assert.AreEqual(expected, result);
        }
    }
}
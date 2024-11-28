using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Plus_One
    {
        public int[] PlusOne(int[] digits)
        {
            var lastDigit = digits[digits.Length - 1];

            if (lastDigit < 9)
            {
                digits[digits.Length - 1] = lastDigit + 1;
                return digits;
            }

            if (digits.Length == 1)
            {
                return [1, 0];
            }

            var subarray = new ArraySegment<int>(digits, 0, digits.Length -1).ToArray();
            return [.. PlusOne(subarray), 0];
        }
    }

    // Generate a testing class for this method using NUnit
    [TestFixture]
    public class PlusOneTests
    {
        private Plus_One solution;

        [SetUp]
        public void SetUp()
        {
            solution = new Plus_One();
        }

        [Test]
        public void Test1()
        {
            var digits = new int[] { 1, 2, 3 };
            var expected = new int[] { 1, 2, 4 };
            var result = solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            var digits = new int[] { 4, 3, 2, 1 };
            var expected = new int[] { 4, 3, 2, 2 };
            var result = solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            var digits = new int[] { 9 };
            var expected = new int[] { 1, 0 };
            var result = solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test4()
        {
            var digits = new int[] { 9, 9 };
            var expected = new int[] { 1, 0, 0 };
            var result = solution.PlusOne(digits);
            Assert.That(result, Is.EqualTo(expected));
        }
    }


}

using NUnit.Framework;

namespace LeetCode
{
    public class Remove_Element
    {
        public static int RemoveElement(int[] nums, int val)
        {
            var k = 0;
            var lastPositionWithValue = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] != val)
                {
                    k++;
                    continue;
                }

                if (lastPositionWithValue > i)
                {
                    nums[i] = nums[lastPositionWithValue];
                    nums[lastPositionWithValue] = val+1;
                    lastPositionWithValue--;
                }
                else
                {
                    nums[i] = val+1;
                    lastPositionWithValue = i-1;
                }
            }
            return k;
        }
    }

    // Generate a testing class for this method using NUnit
    [TestFixture]
    public class RemoveElementTests
    {
        private Remove_Element solution;
        
        [SetUp]
        public void SetUp()
        {
            solution = new Remove_Element();
        }

        [Test]
        public void Test1()
        {
            var nums = new int[] { 3, 2, 2, 3 };
            var expectedArray = new int[] { 2, 2 };
            var val = 3;
            var expected = 2;
            var result = Remove_Element.RemoveElement(nums, val);
            Assert.That(result, Is.EqualTo(expected));
            // Assert that first k values in nums contains all the numbers in the array except the val
            for (int i = 0; i < expected; i++)
            {
                // Assert that expectedArray[i] is present in nums
                Assert.That(nums.Take(expected).Contains(expectedArray[i]), Is.True);
            }
        }

        [Test]
        public void Test2()
        {
            var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var expectedArray = new int[] { 0, 1, 3, 0, 4 };
            var val = 2;
            var expected = 5;
            var result = Remove_Element.RemoveElement(nums, val);
            Assert.That(result, Is.EqualTo(expected));
            // Assert that first k values in nums contains all the numbers in the array except the val
            for (int i = 0; i < expected; i++)
            {
                // Assert that expectedArray[i] is present in nums
                Assert.That(nums.Take(expected).Contains(expectedArray[i]), Is.True);
            }
        }

        [Test]
        public void Test3()
        {
            var nums = new int[] { 0, 1, 2, 2, 3, 0, 2, 2 };
            var expectedArray = new int[] { 0, 1, 3, 0 };
            var val = 2;
            var expected = 4;
            var result = Remove_Element.RemoveElement(nums, val);
            Assert.That(result, Is.EqualTo(expected));
            // Assert that first k values in nums contains all the numbers in the array except the val
            for (int i = 0; i < expected; i++)
            {
                // Assert that expectedArray[i] is present in nums
                Assert.That(nums.Take(expected).Contains(expectedArray[i]), Is.True);
            }
        }

        [Test]
        public void Test4()
        {
            var nums = new int[] { 2 };
            var expectedArray = new int[] { };
            var val = 2;
            var expected = 0;
            var result = Remove_Element.RemoveElement(nums, val);
            Assert.That(result, Is.EqualTo(expected));
            // Assert that first k values in nums contains all the numbers in the array except the val
            for (int i = 0; i < expected; i++)
            {
                // Assert that expectedArray[i] is present in nums
                Assert.That(nums.Take(expected).Contains(expectedArray[i]), Is.True);
            }
        }

        [Test]
        public void Test5()
        {
            var nums = new int[] { 1, 2, 3, 4 };
            var expectedArray = new int[] { 2, 3, 4 };
            var val = 1;
            var expected = 3;
            var result = Remove_Element.RemoveElement(nums, val);
            Assert.That(result, Is.EqualTo(expected));
            // Assert that first k values in nums contains all the numbers in the array except the val
            for (int i = 0; i < expected; i++)
            {
                // Assert that expectedArray[i] is present in nums
                Assert.That(nums.Take(expected).Contains(expectedArray[i]), Is.True);
            }
        }
    }
}

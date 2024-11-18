using NUnit.Framework;

/// <summary>
/// Merge two sorted arrays and store them in nums1
/// </summary>
/// <param name="nums1"></param>
/// <param name="m"></param>
/// <param name="nums2"></param>
/// <param name="n"></param>
void Merge(int[] nums1, int m, int[] nums2, int n)
{
    if (n == 0)
        return;

    var mIndex = m-1;
    var nIndex = n-1;

    for (int i = n+m-1; i >= 0; i--)
    {
        if (mIndex < 0)
        {
            nums1[i] = nums2[nIndex];
            nIndex--;
            continue;
        }

        if (nIndex < 0)
        {
            nums1[i] = nums1[mIndex];
            mIndex--;
            continue;
        }

        var num1 = mIndex >= 0 ? nums1[mIndex] : 0;
        var num2 = nIndex >= 0 ? nums2[nIndex] : 0;

        if(num2 >= num1)
        {
            nums1[i] = num2;
            nIndex--;
        }
        else
        {
            nums1[i] = num1;
            mIndex--;
        }
    }
}

// Arrange
var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
var nums2 = new int[] { 2, 5, 6 };
int m = 3;
int n = 3;
var expected = new int[] { 1, 2, 2, 3, 5, 6 };

// Act
Merge(nums1, m, nums2, n);

// Assert
Assert.That(nums1, Is.EqualTo(expected));

// Arrange
nums1 = new int[] { 1 };
nums2 = new int[] { };
m = 1; 
n = 0;
expected = new int[] { 1 };

// Act
Merge(nums1, m, nums2, n);

// Assert
Assert.That(nums1, Is.EqualTo(expected));

// Arrange
nums1 = new int[] { 0 };
nums2 = new int[] { 1 };
m = 0;
n = 1;
expected = new int[] { 1 };

// Act
Merge(nums1, m, nums2, n);

// Assert
Assert.That(nums1, Is.EqualTo(expected));

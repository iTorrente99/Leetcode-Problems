/*
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
The overall run time complexity should be O(log (m+n)).

Example 1:
Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.

Example 2:
Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

SOLUTION:
Time complexity -> O(log(min(nums1.Length, nums2.Length)))
*/
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length) {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int lengthNums1 = nums1.Length;
        int lengthNums2 = nums2.Length;
        int minIndex = 0, maxIndex = lengthNums1, medianPos = (lengthNums1 + lengthNums2 + 1) / 2;

        while (minIndex <= maxIndex) {
            int partitionNums1 = (minIndex + maxIndex) / 2;
            int partitionNums2 = medianPos - partitionNums1;

            int maxLeftNums1 = GetMaxLeft(nums1, partitionNums1);
            int minRightNums1 = GetMinRight(nums1, partitionNums1, lengthNums1);
            int maxLeftNums2 = GetMaxLeft(nums2, partitionNums2);
            int minRightNums2 = GetMinRight(nums2, partitionNums2, lengthNums2);

            if (maxLeftNums1 <= minRightNums2 && maxLeftNums2 <= minRightNums1) {
                if ((lengthNums1 + lengthNums2) % 2 == 0) {
                    return CalculateMedian(lengthNums1, lengthNums2, maxLeftNums1, minRightNums1, maxLeftNums2, minRightNums2);
                } else {
                    return Math.Max(maxLeftNums1, maxLeftNums2);
                }
            } else if (maxLeftNums1 > minRightNums2) {
                maxIndex = partitionNums1 - 1;
            } else {
                minIndex = partitionNums1 + 1;
            }
        }

        return 0;
    }

    private int GetMaxLeft(int[] nums, int partition) {
        return partition == 0 ? int.MinValue : nums[partition - 1];
    }

    private int GetMinRight(int[] nums, int partition, int length) {
        return partition == length ? int.MaxValue : nums[partition];
    }

    private double CalculateMedian(int lengthNums1, int lengthNums2, int maxLeftNums1, int minRightNums1, int maxLeftNums2, int minRightNums2) {
        if ((lengthNums1 + lengthNums2) % 2 == 0) {
            return (Math.Max(maxLeftNums1, maxLeftNums2) + Math.Min(minRightNums1, minRightNums2)) / 2.0;
        } else {
            return Math.Max(maxLeftNums1, maxLeftNums2);
        }
    }
}
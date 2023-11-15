/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]

SOLUTION:
Time complexity -> O(N log N)
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] sortedArray = new int[nums.Length];
        Array.Copy(nums, sortedArray, nums.Length);
        Array.Sort(sortedArray);

        int leftIndex = 0;
        int rightIndex = nums.Length - 1;
        while (leftIndex != rightIndex) {
            if (sortedArray[leftIndex] + sortedArray[rightIndex] == target) {
                return new int[] {
                    Array.IndexOf(nums, sortedArray[leftIndex]), 
                    Array.LastIndexOf(nums, sortedArray[rightIndex])
                };
            }
            else if (sortedArray[leftIndex] + sortedArray[rightIndex] < target) {
                leftIndex++;
            }
            else {
                rightIndex--;
            }
        }

        return null;
    }
}
'''
Write a function to find the longest common prefix string amongst an array of strings.
If there is no common prefix, return an empty string "".

Example 1:
Input: strs = ["flower","flow","flight"]
Output: "fl"

Example 2:
Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.

SOLUTION:
Time complexity -> O(n)
'''
class Solution(object):
    def longestCommonPrefix(self, strs):
        if not strs:
            return ""

        min_len = min(len(s) for s in strs)
        low, high = 0, min_len
        
        while low <= high:
            mid = (low + high) // 2
            if all(s[:mid] == strs[0][:mid] for s in strs):
                low = mid + 1
            else:
                high = mid - 1
        
        return strs[0][:high]
/*
Given a string s, find the length of the longest 
substring without repeating characters.

Example 1:
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.

Example 2:
Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.

Example 3:
Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

SOLUTION:
Time complexity -> O(n)
*/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> charIndex = new Dictionary<char, int>();
        int maxSubstrLength = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++) {
            if (charIndex.ContainsKey(s[right]) && charIndex[s[right]] >= left) {
                left = charIndex[s[right]] + 1;
            }
            charIndex[s[right]] = right;
            maxSubstrLength = Math.Max(maxSubstrLength, right - left + 1);
        }

        return maxSubstrLength;
    }
}
/*
Given a string s, return the longest 
palindromic substring in s.

Example 1:
Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.

Example 2:
Input: s = "cbbd"
Output: "bb"

SOLUTION:
Time complexity -> O(^2)
*/
public class Solution {
    public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return "";

        int startIndexOfMaxPalindrome = 0, maxLengthOfPalindrome = 0;

        for (int centerIndex = 0; centerIndex < s.Length; centerIndex++) {
            int left = centerIndex, right = centerIndex;

            // odd
            while (left >= 0 && right < s.Length && s[left] == s[right]) {
                if (right - left + 1 > maxLengthOfPalindrome) {
                    maxLengthOfPalindrome = right - left + 1;
                    startIndexOfMaxPalindrome = left;
                }
                left--;
                right++;
            }

            left = centerIndex; 
            right = centerIndex + 1;

            // even
            while (left >= 0 && right < s.Length && s[left] == s[right]) {
                if (right - left + 1 > maxLengthOfPalindrome) {
                    maxLengthOfPalindrome = right - left + 1;
                    startIndexOfMaxPalindrome = left;
                }
                left--;
                right++;
            }
        }

        return s.Substring(startIndexOfMaxPalindrome, maxLengthOfPalindrome);
    }
}
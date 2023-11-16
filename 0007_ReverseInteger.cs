/*
Given a signed 32-bit integer x, return x with its digits reversed. 
If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

Example 1:
Input: x = 123
Output: 321

Example 2:
Input: x = -123
Output: -321

Example 3:
Input: x = 120
Output: 21

SOLUTION:
Time complexity -> O(n)
*/
public class Solution {
    public int Reverse(int x) {
        string reversedString = ReverseString(Convert.ToString(x));

        int result;
        if (int.TryParse(reversedString, out result)) {
            return result;
        } else {
            return 0;
        }
    }

    private string ReverseString(string s) {
        StringBuilder reversed = new StringBuilder();
        int start = 0;

        if (s[0] == '-') {
            reversed.Append('-');
            start = 1;
        }
        for (int i = s.Length - 1; i >= start; i--) {
            reversed.Append(s[i]);
        }
        if (reversed.Length > 0 && reversed[0] == '-') {
            reversed.Remove(0, 1);
            reversed.Insert(0, '-');
        }

        return reversed.ToString();
    }
}
'''
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000

For example, 2 is written as II in Roman numeral, just two one's added together. 
12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. 
Instead, the number four is written as IV. Because the one is before the five we subtract it making four. 
The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given an integer, convert it to a roman numeral.

Example 1:
Input: num = 3
Output: "III"
Explanation: 3 is represented as 3 ones.

Example 2:
Input: num = 58
Output: "LVIII"
Explanation: L = 50, V = 5, III = 3.

Example 3:
Input: num = 1994
Output: "MCMXCIV"
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

SOLUTION:
Time complexity -> O(1)
'''
class Solution(object):
    def intToRoman(self, num):
        result = ""
        
        result += "M" * (num // 1000)
        num -= (num // 1000) * 1000
        if num // 100 == 9:
            result += "CM"
            num -= 900
        elif num // 100 == 4:
            result += "CD"
            num -= 400
        else:
            result += "D" * (num // 500)
            num -= (num // 500) * 500
            result += "C" * (num // 100)
            num -= (num // 100) * 100
        if num // 10 == 9:
            result += "XC"
            num -= 90
        elif num // 10 == 4:
            result += "XL"
            num -= 40
        else:
            result += "L" * (num // 50)
            num -= (num // 50) * 50
            result += "X" * (num // 10)
            num -= (num // 10) * 10
        if num // 1 == 9:
            result += "IX"
            num -= 9
        elif num // 1 == 4:
            result += "IV"
            num -= 4
        else:
            result += "V" * (num // 5)
            num -= (num // 5) * 5
            result += "I" * (num // 1)
            num -= (num // 1)
        
        return result
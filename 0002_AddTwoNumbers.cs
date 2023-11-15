/**
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. 
Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example 1:
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.

Example 2:
Input: l1 = [0], l2 = [0]
Output: [0]

Example 3:
Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]

SOLUTION:
Time complexity -> O(N) 

 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = new ListNode(0);
        ListNode pointer1 = l1, pointer2 = l2, current = result;
        int carry = 0;

        while (pointer1 != null || pointer2 != null) {
            int val1 = (pointer1 != null) ? pointer1.val : 0;
            int val2 = (pointer2 != null) ? pointer2.val : 0;
            int sum = carry + val1 + val2;
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;

            if (pointer1 != null) pointer1 = pointer1.next;
            if (pointer2 != null) pointer2 = pointer2.next;
        }

        if (carry > 0) {
            current.next = new ListNode(carry);
        }

        return result.next;
    }
}
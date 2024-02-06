/**
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

//Solution using dummy nodes
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode Result = new ListNode();
        ListNode List = Result;
        while(true)
        {
            if (list1 == null)
            {
                List.next = list2;
                break;
            }
            if(list2 == null)
            {
                List.next = list1;
                break;
            }
            if(list1.val <= list2.val)
            {
                List.next = list1;
                list1 = list1.next;
            }
            else
            {
                List.next = list2;
                list2 = list2.next;
            }
            List = List.next;

        }
        return Result.next;
        
    }
}

//solution using Recursion

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null)
        {
            return list2;
        }
        if(list2 == null)
        {
            return list1;
        }
        if(list1.val <= list2.val)
        {
            list1.next = this.MergeTwoLists(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = this.MergeTwoLists(list1, list2.next);
            return list2;
        }
    }
}
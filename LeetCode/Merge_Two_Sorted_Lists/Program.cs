namespace Merge_Two_Sorted_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Difficulty: Easy
            Console.WriteLine("Hello, World!");
        }
    }
}

   //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) 
        {
          this.val = val;
          this.next = next;
        }
    }
 
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = new ListNode(-1);
        ListNode temp = head;
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                temp.next = list1;
                list1 = list1.next;
            }
            else
            {
                temp.next = list2;
                list2 = list2.next;
            }
            temp = temp.next;
        }
        if (list1 != null)
        {
            temp.next = list1;
        }
        else if (list2 != null)
        {
            temp.next = list2;
        }
        return head.next;
    }
}
namespace Swap_Nodes_In_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Difficulty: Medium
            Console.WriteLine("Hello, World!");
        }
    }
    
 //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode initialNode = new ListNode(0, head);
            ListNode previous = initialNode;
            ListNode current = head;
            while (current != null && current.next != null)
            {
                ListNode a = current, b = current.next;
                a.next = b.next;
                b.next = a;
                previous.next = b;
                previous = a;
                current = previous.next;

            }
            return initialNode.next;
        }
    }
}
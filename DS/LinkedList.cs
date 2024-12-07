using System;

namespace DS
{
    public class ListNode
    {
        public ListNode(int i, ListNode next = null)
        {
            val = i;
            next = null;
        }

        public int val { get; set; }
        public ListNode next { get; set; }
    }

    public class LinkedList
    {
        public ListNode head;
        public LinkedList(int val)
        {
            head = new ListNode(val, null);
        }

        public void AddAtHead(int val)
        {
            ListNode newNode = new ListNode(val, null);
            var prev = head;
            newNode.next = prev;
            head = newNode;
        }

        //public void AddToTail(int val)
        //{
        //    ListNode newNode = new ListNode(val, null);
        //    var prev = head;
        //    head = newNode;
        //    head.next = prev;
        //}

        public void RemoveNFromLast(int N)
        {

        }

        public void AddFirst(ListNode node)
        {

        }
        public void AddLast(ListNode node)
        {
        }

        public void AddAfter(ListNode node, ListNode newNode)
        {

        }
        public void AddBefore(ListNode node, ListNode newNode)
        {

        }
        
        public void RemoveFirst()
        {

        }
        public void RemoveLast()
        {

        }

    }
}

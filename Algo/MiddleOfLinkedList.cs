using DS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Algorigthms
{
    
    // Definition for singly-linked list.

    public class MiddleOfLinkedList
    {
        public static ListNode Algorithm(ListNode head)
        {
            ListNode fast = head;

            while (fast.next != null)
            {
                head = head.next;
                fast = fast.next.next;
                if (fast == null) break;
            }
            return head;
        }

    }
   
}

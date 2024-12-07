using DS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class MergeLinkedList
    {

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            var list1Next = list1.next;
            var list2Next = list2.next;
            ListNode head = null;
            while ((list2 != null && list2.next != null) || (list1 != null && list1.next != null))
            {
                if (list1.val <= list2.val)
                {
                    if (head == null) head = list1;
                    list1.next = list2;
                    if (list1Next != null)
                    {
                        list2 = list1Next;
                        list2Next = list2.next;
                    }
                }
                else
                {
                    if (head == null) head = list2;
                    list2.next = list1;
                    if (list2Next != null)
                    {
                        list1 = list2Next;
                        list1Next = list1.next;
                    }
                }
            }
            //if(list1!=null) list1.next=list2;
            //if(list2!=null) list2.next=list1;

            return head;


        }

    }
}

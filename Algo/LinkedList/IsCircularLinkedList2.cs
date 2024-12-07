using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS;

namespace Algorigthms.LinkedList
{
    internal class IsCircularLinkedList2
    {
        public ListNode DetectCycle(ListNode head)
        {

            HashSet<ListNode> listSet = new HashSet<ListNode>();
            while(head != null && head.next!=null)
            {
                if (listSet.Contains(head)) break;
            }

            return head;

        }


    }
}

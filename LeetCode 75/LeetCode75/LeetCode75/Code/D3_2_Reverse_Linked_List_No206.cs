using LeetCode75.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.Code
{
    internal class D3_2_Reverse_Linked_List_No206
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            //取得最後一個節點
            ListNode getLast = head;
            while (getLast.next != null)
            {
                getLast = getLast.next;
            }

            //遞迴翻轉節點
            GetNext(head);

            return getLast;
        }

        public ListNode GetNext(ListNode head)
        {
            if (head.next != null)
            {
                var result = GetNext(head.next);
                head.next = null;
                result.next = head;
            }

            return head;
        }

        internal void PrintResult(ListNode result)
        {
            while (result != null)
            {
                Console.Write($"{result.val} ");
                result = result.next;
            }
            Console.WriteLine();
        }

        internal ListNode[] GetInitialData()
        {
            return new ListNode[] {
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))))
                //new ListNode(1, new ListNode(2))
            };
        }
    }
}
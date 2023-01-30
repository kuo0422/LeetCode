using LeetCode75.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.Code
{
    internal class D3_1_Merge_Two_Sorted_Lists_No21
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode resultNode, nowNode, checkNode, tempNode;
            if (list1.val <= list2.val)
            {
                resultNode = list1;
                checkNode = list2;
            }
            else
            {
                resultNode = list2;
                checkNode = list1;
            }

            nowNode = resultNode;
            while (nowNode.next != null)
            {
                if (nowNode.next.val > checkNode.val)
                {
                    tempNode = nowNode.next;
                    nowNode.next = checkNode;
                    checkNode = tempNode;
                }
                nowNode = nowNode.next;
            }

            if (checkNode != null) nowNode.next = checkNode;

            return resultNode;
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
                new ListNode(1, new ListNode(2, new ListNode(4))),
                new ListNode(1, new ListNode(3, new ListNode(4)))
            };
        }
    }
}
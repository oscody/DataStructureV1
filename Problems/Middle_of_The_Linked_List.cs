                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           using System;
using DataStructureV1.DataStructures;

namespace DataStructureV1.Problems
{
	public static class Middle_of_The_Linked_List
	{

        public static void Test() {


            var problem = "Middle of The Linked List";

            var together = problem.Replace(" ", "_");

            Console.WriteLine(together);



            ListNode node5 = new ListNode(5);
            ListNode node4 = new ListNode(4, node5);
            ListNode node3 = new ListNode(3, node4);
            ListNode node2 = new ListNode(2, node3);
            ListNode head = new ListNode(1, node2);


            Solve1(head);
        }

        private static void  Solve1(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {

                Console.WriteLine("slow-"+slow.val);
                Console.WriteLine("fast-" + fast.val);
                slow = slow.next;         // move slow by 1 step
                fast = fast.next.next;   // move fast by 2 steps
            }

            Console.WriteLine(slow.val);
        }

    }
}


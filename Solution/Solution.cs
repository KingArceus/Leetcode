﻿global using Utils;

namespace Problem
{
    public class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode ret = new ListNode();
            ListNode l3 = ret;
            bool remember = false;

            while (l1 != null || l2 != null)
            {
                l3.val = ((l1 == null) ? 0 : l1.val) + ((l2 == null) ? 0 : l2.val) + (remember ? 1 : 0);

                remember = false;
                if (l3.val > 9)
                {
                    remember = true;
                    l3.val -= 10;
                }

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
                if (l1 != null || l2 != null) l3.next = new ListNode();
                else if (l1 == null && l2 == null && remember) l3.next = new ListNode(1);
                l3 = l3.next;
            }

            return ret;
        }
    }

}

global using Utils;

namespace Problem
{
    public static class Solution
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

        public static long MinEnd(int n, int x)
        {
            long result = x;
            long remaining = n - 1;
            long position = 1;

            while (remaining != 0)
            {
                if ((x & position) == 0)
                {
                    result |= (remaining & 1) * position;
                    remaining >>= 1;
                }
                position <<= 1;
            }

            return result;
        }

        public static long CountFairPairs(int[] nums, int lower, int upper)
        {
            Array.Sort(nums);

            var count = (int target) =>
            {
                long ret = 0;

                int i = 0;
                int j = nums.Length - 1;
                while (i < j)
                {
                    if (nums[i] + nums[j] > target) j--;
                    else
                    {
                        ret += j - i;
                        i++;
                    };
                }

                return ret;
            };

            return count(upper) - count(lower - 1);
        }
    }
}

namespace Utils
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode(List<int> List)
        {
            ListNode tmp = NewListNodeFromArray(List);
            this.val = tmp.val;
            this.next = tmp.next;
        }

        public static ListNode NewListNodeFromArray(List<int> L)
        {
            ListNode ret = new ListNode();
            ListNode tmp = ret;

            for (int i = 0; i < L.Count; i++)
            {
                tmp.val = L[i];
                if (i + 1 < L.Count) tmp.next = new ListNode(); 
                tmp = tmp.next;
            }

            return ret;
        }

        public override string ToString()
        {
            string ret = val.ToString();
            ListNode tmp = next;

            while (tmp != null)
            {
                ret += " => " + tmp.val.ToString();
                tmp = tmp.next;
            }

            return ret;
        }
    }
}

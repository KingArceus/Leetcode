using Problem;

//List<int> list1 = [9, 9, 9, 9, 9, 9, 9];
//List<int> list2 = [9, 9, 9, 9];
//var l1 = new ListNode(list1);
//var l2 = new ListNode(list2);

// Console.WriteLine(Solution.AddTwoNumbers(l1, l2));

// 3133. Minimum Array End
int n = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Solution.MinEnd(n, x));
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine(Solution.Reverse("hello"));
            var start = DateTime.Now.Millisecond;
            /*
            var nums = MyArray.TwoSum(new int[]{
                3,1,4,7,8,9
            }, 15);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }*/
            /*
            var l1 = new Solution.ListNode (2);
            l1.next = new Solution.ListNode(5);
            var l2 = new Solution.ListNode (2);
            l2.next = new Solution.ListNode(4);
            Solution.AddTwoNumbers(l1, l2);*/

            //https://leetcode.com/problems/reverse-integer/
            //Console.WriteLine(MyArray.Reverse(56));
            //Console.WriteLine(MyArray.Reverse(-12));
            //Console.WriteLine($"Eat time: {System.DateTime.Now.Millisecond-start}");
            //BinaryTreeSolution.PreorderTest();
            var s = new Solution();
            /*
            Console.WriteLine(s.Fibonacci(1));
            Console.WriteLine(s.Fibonacci(2));
            Console.WriteLine(s.Fibonacci(3));
            Console.WriteLine(s.Fibonacci(4));
            Console.WriteLine(s.Fibonacci(5));

            var arr = new int[] { 3, 2, 2, 3 };
            Console.WriteLine(s.RemoveElement(arr, 3));
            */

            //string.IndexOf() 实现
            Console.WriteLine(s.StrStr("hello", "ll"));
            Console.WriteLine(s.StrStr("mississippi", "issip"));
            Console.WriteLine(s.StrStr("mississippi", "issipi"));
            Console.WriteLine(s.StrStr("aaaa", "bba"));
            Console.Read();
        }
    }
}
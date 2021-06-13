using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            /*
             * https://leetcode-cn.com/problems/two-sum/description/
             * 给定一个整数数组和一个目标值，找出数组中和为目标值的两个数。

            你可以假设每个输入只对应一种答案，且同样的元素不能被重复利用。
            示例:
                给定 nums = [2, 7, 11, 15], target = 9
            因为 nums[0] + nums[1] = 2 + 7 = 9
            所以返回 [0, 1]
             */
            int ia = 0;
            int ib = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    { ia = i; ib = j; }
                }
            }
            return new int[] { ia, ib };
        }

        /*
         https://leetcode-cn.com/problems/add-two-numbers/description/
             */

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            StringBuilder sb = new StringBuilder();
            ListNode a1 = l1, a2 = l2;
            while (a1 != null)
            {
                sb.Append(a1.val);
                Console.Write(a1.val);
                a1 = a1.next;
            }
            int a = int.Parse(sb.ToString());
            sb.Clear();
            foreach (var i in a.ToString().Reverse())
            {
                sb.Append(i);
            }
            a = int.Parse(sb.ToString());
            Console.WriteLine($"a = {a}");
            sb.Clear();

            while (a2 != null)
            {
                sb.Append(a2.val);
                a2 = a2.next;
            }
            int b = int.Parse(sb.ToString());
            sb.Clear();
            foreach (var i in b.ToString().Reverse())
            {
                sb.Append(i);
            }
            b = int.Parse(sb.ToString());
            Console.WriteLine($"b = {b}");
            int resultnum = a + b;
            Console.WriteLine($"a+b = {a + b}");
            var result = new ListNode(resultnum.ToString().ToCharArray()[0]);
            var n = new ListNode(result.val);
            foreach (var item in resultnum.ToString().Reverse())
            {
                n.val = item;
                n = n.next;
            }
            var tmp = result;
            while (tmp != null)
            {
                Console.Write(tmp);
                tmp = tmp.next;
            }
            return result;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
            }
        }

        /// <summary>
        /// 搜索二维矩阵
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            /*
             * 编写一个高效的算法来判断 m x n 矩阵中，是否存在一个目标值。该矩阵具有如下特性：
             * 每行中的整数从左到右按升序排列。
             * 每行的第一个整数大于前一行的最后一个整数。
             * 示例 1:
                输入:
                matrix = [
                  [1,   3,  5,  7],
                  [10, 11, 16, 20],
                  [23, 30, 34, 50]
                ]
                target = 3
                输出: true
             */
            if (matrix.Length < 1 || matrix[0, 0] > target)
            {
                return false;
            }
            for (int i = 0; i < matrix.GetUpperBound(i) + 1; i++)
            {
                if (matrix[i, 0] > target)
                {
                    break;
                }
                else if (matrix[i, 0].Equals(target))
                {
                    return true;
                }
                for (int j = matrix.GetLength(i) - 1; j > 0; j--)
                {
                    if (matrix[i, j].Equals(target))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static double MyPow(double x, int n)
        {
            double res = x;
            if (n == 0) return 1;
            res = MyPow(x, n);
            /*
            if (n > 0)
            {
                while (--n > 0)
                {
                    res *= x;
                }
            }
            else if (n < 0)
            {
                while (++n < 2)
                {
                    res /= x;
                }
            }*/
            if (n > 0)
            {
                res = MyPow(x, --n);
            }
            else if (n < 0)
            {
                res = MyPow(x, ++n);
            }
            return res;
        }

        /// <summary>
        ///  移除元素
        ///  https://leetcode-cn.com/problems/remove-element/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement(int[] nums, int val)
        {
            /*
             * 给定一个数组 nums 和一个值 val，你需要原地移除所有数值等于 val 的元素，返回移除后数组的新长度。
             * 不要使用额外的数组空间，你必须在原地修改输入数组并在使用 O(1) 额外空间的条件下完成。
             * 元素的顺序可以改变。你不需要考虑数组中超出新长度后面的元素。
             *      示例 1:
             *      给定 nums = [3,2,2,3], val = 3,
             *      函数应该返回新的长度 2, 并且 nums 中的前两个元素均为 2。
             * 你不需要考虑数组中超出新长度后面的元素。
             */
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }

        public static bool IsValid(string s)
        {
            var param1 = "()";
            var param2 = "[]";
            var param3 = "{}";
            for (int i = 0; i < s.Length - 1; i += 2)
            {
                var varify = s[i].ToString() + s[i + 1].ToString();
                if (varify != param1 && varify != param2 && varify != param3)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 三数之和
        /// https://leetcode-cn.com/problems/3sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            /*
             * 给定一个包含 n 个整数的数组 nums，判断 nums 中是否存在三个元素 a，b，c ，使得 a + b + c = 0 ？找出所有满足条件且不重复的三元组。
             * 注意：答案中不可以包含重复的三元组。
             * 例如, 给定数组 nums = [-1, 0, 1, 2, -1, -4]，
             *  满足要求的三元组集合为：
             *  [
             *      [-1, 0, 1],
             *      [-1, -1, 2]
             *  ]
             */
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    for (int k = 0; k < nums.Length; k++)
                    {
                        if ((i != j && j != k && i != k) && nums[i] + nums[j] + nums[k] == 0)
                        {
                            List<int> s = new List<int> {
                                    nums[i], nums[j],nums[k]
                                };
                            res.Add(s);
                        }
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// 爬楼梯
        /// https://leetcode-cn.com/problems/climbing-stairs/comments/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ClimbStairs(int n)
        {
            /*
             * 假设你正在爬楼梯。需要 n 阶你才能到达楼顶。
             * 每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？
             * 注意：给定 n 是一个正整数。
             */
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;
            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }

        /// <summary>
        /// 反转字符串
        /// https://leetcode-cn.com/problems/reverse-string/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Reverse(string s)
        {
            StringBuilder sb = new StringBuilder();
            var chars = s.ToArray();
            for (int i = chars.Count() - 1; i > -1; i--)
            {
                sb.Append(chars[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/nim-game/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool CanWinNim(int n)
        {
            if (n < 4) return true;
            if (n == 4) return false;
            return n % (2 + 1) != 0;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/guess-number-higher-or-lower-ii/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GetMoneyAmount(int n)
        {
            int money = 0;
            int start = 1;

            return money;
        }

        /// <summary>
        /// 二分查找字符串
        /// https://leetcode-cn.com/problems/sparse-array-search-lcci/
        /// </summary>
        /// <param name="words"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FindString(string[] words, string s)
        {
            int len = words.Length;
            int mid = len / 2 + 1;
            for (int i = 0, j = len - 1; i < mid; i++, j--)
            {
                if (words[i].Length > 0 && words[i] == s) return i;
                if (words[j].Length > 0 && words[j] == s) return j;
            }
            return -1;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/permutation-ii-lcci/
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public string[] Permutation(string S)
        {
            var hashSet = new HashSet<string>();
            var arr = S.ToCharArray();
            int len = arr.Length;
            var rand = new Random(len);

            for (int i = 0; i < len; i++)
            {
                var temp = "";
                var arr2 = Shuffle(arr);
                for (int j = 0; j < len; j++)
                {
                    temp += arr2[j];
                }
                hashSet.Add(temp);
            }
            return hashSet.ToArray();
        }

        public char[] Shuffle(char[] arr)
        {
            var rand = new Random();
            var len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                var temp = arr[i];
                var rnd = rand.Next(0, len);
                arr[i] = arr[rnd];
                arr[rnd] = temp;
            }
            return arr;
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/uncommon-words-from-two-sentences/
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public string[] UncommonFromSentences(string A, string B)
        {
            var dic = new Dictionary<string, int>();
            var arrA = A.Split(' ');
            var arrB = B.Split(' ');
            foreach (var item in arrA)
            {
                if (dic.ContainsKey(item))
                    dic[item] += 1;
                else
                    dic[item] = 1;
            }
            foreach (var item in arrB)
            {
                if (dic.ContainsKey(item))
                    dic[item] += 1;
                else
                    dic[item] = 1;
            }
            return dic.Where(k => k.Value < 2).Select(k => k.Key).ToArray();
        }

        /// <summary>
        /// 斐波那契数列
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fibonacci(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 1;
            if (n == 3) return 2;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        /// <summary>
        /// 实现 strStr()（IndexOf）
        /// 实现 strStr() 函数。
        /*
        给你两个字符串 haystack 和 needle ，请你在 haystack 字符串中找出 needle 字符串出现的第一个位置（下标从 0 开始）。如果不存在，则返回  -1 。
        说明：
        当 needle 是空字符串时，我们应当返回什么值呢？这是一个在面试中很好的问题。
        对于本题而言，当 needle 是空字符串时我们应当返回 0 。
        这与 C 语言的 strstr() 以及 Java 的 indexOf() 定义相符。

        示例 1：
        输入：haystack = "hello", needle = "ll"
        输出：2

        示例 2：
        输入：haystack = "aaaaa", needle = "bba"
        输出：-1

        示例 3：
        输入：haystack = "", needle = ""
        输出：0

        来源：力扣（LeetCode）
        链接：https://leetcode-cn.com/problems/implement-strstr
        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        */

        /// </summary>
        /// <param name="haystack">原始字符串</param>
        /// <param name="needle">欲查找字符串</param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            if (haystack == null)
            {
                return -1;
            }
            if (needle == null)
                return -1;
            if (needle == string.Empty)
                return 0;
            if (string.Equals(haystack, needle))
                return 0;

            int src_len = haystack.Length; // 原始字符串长度
            int p_len = needle.Length; // 欲查找字符串长度
            if (p_len > src_len) return -1;

            int begain = -1;
            int p_index = 0;
            int seed = 0;
            while (true)
            {
                for (int i = seed; i < src_len; i++)
                {
                    if (begain == -1)
                    {
                        if (haystack[i] == needle[p_index])
                        {
                            begain = i;
                            p_index += 1;
                        }
                    }
                    else if (haystack[i] != needle[p_index])
                    {
                        begain = -1;
                        p_index = 0;
                        seed += 1;
                        break;
                    }
                    else
                    {
                        p_index += 1;
                    }
                    if (begain > -1 && p_index == p_len)
                        break;

                    if (i >= src_len - 1)
                    {
                        seed += 1; begain = -1; p_index = 0;
                    };
                }
                if (begain > -1 && p_index == p_len)
                    break;
                if (seed >= src_len) break;
            }

            return begain;
        }
    }
}
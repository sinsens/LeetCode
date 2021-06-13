using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class MyArray
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            /*
             * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
             * You may assume that each input would have exactly one solution, and you may not use the same element twice.
             * Example:
             *      Given nums = [2, 7, 11, 15], target = 9,
             *      Because nums[0] + nums[1] = 2 + 7 = 9,
             *      return [0, 1].
             */
            for (int i = 0; i < nums.Length; i++) {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) {
                        continue;
                    }
                    if (nums[i] + nums[j] == target) {
                        return new int[]{i,j};
                    }
                }
            }
            return new int[] { };
        }

        public static int[] TwoSum2(int[] nums, int target)
        {
            /*
             * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
             * You may assume that each input would have exactly one solution, and you may not use the same element twice.
             * Example:
             *      Given nums = [2, 7, 11, 15], target = 9,
             *      Because nums[0] + nums[1] = 2 + 7 = 9,
             *      return [0, 1].
             */
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                        return new int[] { i, j };
                }
            }
            return new int[] { };
        }

        /// <summary>
        /// https://leetcode.com/problems/median-of-two-sorted-arrays/
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int a = nums1.Sum();
            int b = nums2.Sum() ;
            return a/b;
        }

        /// <summary>
        /// https://leetcode.com/problems/reverse-integer/
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in x.ToString().Reverse())
            {
                if (int.TryParse(item.ToString(), out int i)) {
                    if(!i.Equals(0))
                        sb.Append(i);
                }else{
                    sb.Insert(0, item); 
                }
            }
            return int.Parse(sb.ToString());
        }
    }
}

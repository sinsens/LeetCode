using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class BinaryTreeSolution
    {
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node()
            {
            }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        /// <summary>
        /// https://leetcode-cn.com/problems/n-ary-tree-preorder-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> Preorder(Node root, IList<int> list)
        {
            list.Add(root.val);
            if (root.children != null)
            {
                foreach (var item in root.children)
                {
                    Preorder(item, list);
                }
            }
            return list;
        }

        public static void PreorderTest()
        {
            var root = new Node(1, new List<Node> {
                new Node(3, new List<Node>
                {
                    new Node(5),
                    new Node(6),
                }),
                new Node(2),
                new Node(4)
            });
            IList<int> list = new List<int>();
            var res = Preorder(root, list);
            Console.WriteLine(string.Join(",", res));
            Console.ReadLine();
        }
    }
}
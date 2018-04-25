using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet145
{
    class Program
    {
       
      public class TreeNode {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int x) { val = x; }
      }
 

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            TreeNode middle = new TreeNode(2);
            TreeNode bottom = new TreeNode(3);

            root.left = null;
            root.right = middle;

            middle.left = bottom;
            middle.right = null;

            IList<int> res = PostorderTraversal(root);

            foreach (int node in res)
            {
                Console.WriteLine(node);
            }
            Console.ReadLine();
        }

        public static IList<int> PostorderTraversal(TreeNode root)
        {

            Stack<TreeNode> stack = new Stack<TreeNode>();

            IList<int> result = new List<int>();

            for (TreeNode lastNode = null, top; root != null || stack.Count != 0;)

                if (root != null)
                {
                    stack.Push(root);
                    root = root.left;

                }
                else if ((top = stack.Peek()).right != null && top.right != lastNode)

                    root = top.right;
                else
                {

                    result.Add(top.val);

                    lastNode = stack.Pop();

                }
            return result;

        }
    }
}

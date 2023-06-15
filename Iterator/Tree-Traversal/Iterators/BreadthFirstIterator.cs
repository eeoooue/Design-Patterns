using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Traversal.Iterators
{
    internal class BreadthFirstIterator : Iterator
    {
        List<TreeNode> _nodes = new List<TreeNode>();
        int _position = 0;

        public BreadthFirstIterator(TreeNode root)
        {
            BreadthFirstTraversal(root);
        }

        private void BreadthFirstTraversal(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int time = queue.Count;

                for(int i=0; i < time; i++)
                {
                    TreeNode node = queue.Dequeue();
                    _nodes.Add(node);

                    if (node.Left != null)
                    {
                        queue.Append(node.Left);
                    }

                    if (node.Right != null)
                    {
                        queue.Append(node.Right);
                    }
                }
            }
        }

        public object GetNext()
        {
            return _nodes[_position++];
        }

        public bool HasMore()
        {
            return (_position < _nodes.Count);
        }
    }
}

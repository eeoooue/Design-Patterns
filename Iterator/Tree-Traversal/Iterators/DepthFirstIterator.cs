using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Traversal.Iterators
{
    internal class DepthFirstIterator : Iterator
    {
        List<TreeNode> _nodes = new List<TreeNode>();
        int _position = 0;

        public DepthFirstIterator(TreeNode root)
        {
            DepthFirstTraversal(root);
        }

        private void DepthFirstTraversal(TreeNode node)
        {
            if (node.Left != null)
            {
                DepthFirstTraversal(node.Left);
            }

            _nodes.Add(node);

            if (node.Right != null)
            {
                DepthFirstTraversal(node.Right);
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

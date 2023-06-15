using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree_Traversal.Iterators;

namespace Tree_Traversal
{
    internal class TreeCollection
    {
        private TreeNode _root;

        public TreeCollection(TreeNode root)
        {
            _root = root;
        }

        public Iterator GetDepthIterator()
        {
            return new DepthFirstIterator(_root);
        }

        public Iterator GetBreadthIterator()
        {
            return new BreadthFirstIterator(_root);
        }
    }
}

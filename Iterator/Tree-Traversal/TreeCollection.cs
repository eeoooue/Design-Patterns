using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public Iterator GetBreadthIterator()
        {
            throw new NotImplementedException();
        }
    }
}

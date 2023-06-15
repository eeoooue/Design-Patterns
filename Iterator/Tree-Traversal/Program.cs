namespace Tree_Traversal
{
    internal class Program
    {

         static Random _randomizer = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine($"Generating random tree:");
            TreeNode root = CreateRandomTreeNode();
            TreeCollection collection = new TreeCollection(root);

            Iterator breadth = collection.GetBreadthIterator();
            PrintIteration(breadth);

            Iterator depth = collection.GetDepthIterator();
            PrintIteration(depth);
        }

        static void PrintIteration(Iterator iterator)
        {
            Console.WriteLine($"Using iterator {iterator}:");

            while (iterator.HasMore())
            {
                object item = iterator.GetNext();

                if (item is TreeNode node)
                {
                    Console.Write($"{node.Val}, ");
                }
            }
            Console.WriteLine();

        }

        static TreeNode CreateRandomTreeNode()
        {
            int val = _randomizer.Next(1, 100);
            TreeNode node = new TreeNode(val);

            if (_randomizer.Next(1, 4) > 2)
            {
                node.Left = CreateRandomTreeNode();
            }

            if (_randomizer.Next(1, 4) > 2)
            {
                node.Right = CreateRandomTreeNode();
            }

            return node;
        }
    }
}
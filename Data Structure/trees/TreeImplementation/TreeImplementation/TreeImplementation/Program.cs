namespace TreeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize the binary tree
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(4);
            tree.Root.Left = new Node(8);
            tree.Root.Right = new Node(7);
            tree.Root.Left.Left = new Node(12);
            tree.Root.Left.Right = new Node(9);

            Console.WriteLine("Original Binary Tree:");
            tree.Print(tree.Root);
            Console.WriteLine("Inorder Traversal of Original Tree:");
            List<int> originalInorder = tree.InorderTraversal();
            Console.WriteLine(string.Join(", ", originalInorder));

            // Convert the tree to its mirror
            tree.Mirror();

            Console.WriteLine("\nMirrored Binary Tree:");
            tree.Print(tree.Root);
            Console.WriteLine("Inorder Traversal of Mirrored Tree:");
            List<int> mirroredInorder = tree.InorderTraversal();
            Console.WriteLine(string.Join(", ", mirroredInorder));

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

            // Demonstrating BinaryTree functionalities
            Console.WriteLine("Binary Tree Example:");
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Root = new Node(1);
            binaryTree.Root.Left = new Node(2);
            binaryTree.Root.Right = new Node(3);
            binaryTree.Root.Left.Left = new Node(4);
            binaryTree.Root.Left.Right = new Node(5);

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.PostOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("Tree Structure:");
            binaryTree.Print(binaryTree.Root);
            Console.WriteLine();

            // Demonstrating BinarySearchTree functionalities
            Console.WriteLine("Binary Search Tree Example:");
            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);
            bst.Add(12);
            bst.Add(20);

            Console.WriteLine("Tree Structure:");
            bst.Print(bst.Root);
            Console.WriteLine();

            Console.WriteLine("Check if 7 exists:");
            Console.WriteLine(bst.Contains(7)); // Output: True

            Console.WriteLine("Check if 3 exists:");
            Console.WriteLine(bst.Contains(3)); // Output: False

            Console.WriteLine("Remove node with value 5:");
            bst.Remove(5);
            bst.Print(bst.Root);
            Console.WriteLine();

            Console.WriteLine("Check if 5 exists after removal:");
            Console.WriteLine(bst.Contains(5)); // Output: False
        }
    }
}
using System.Xml.Linq;
using TreeImplementation;

namespace TreeTest
{
    public class BinaryTreeTest
    {
        [Fact]
        public void TestPreOrder()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                tree.PreOrder(tree.Root);
                var result = sw.ToString().Trim();

                Assert.Equal("1 2 4 5 3", result);
            }
        }

    }
}
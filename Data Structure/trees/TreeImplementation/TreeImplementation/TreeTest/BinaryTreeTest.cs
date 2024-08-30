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


        [Fact]
        public void FindSecondMax_ReturnsCorrectValue()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Left = new Node(5);
            Btree.Root.Right = new Node(20);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(15);
            Btree.Root.Right.Right = new Node(25);

            // Act
            int result = Btree.FindSecondMax();

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void FindSecondMax_ThrowsException_ForEmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => Btree.FindSecondMax());
        }

        [Fact]
        public void FindSecondMax_ThrowsException_ForSingleValueTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => Btree.FindSecondMax());
        }

        [Fact]
        public void FindSecondMax_ThrowsException_ForTreeWithDuplicateValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Left = new Node(10);
            Btree.Root.Right = new Node(10);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => Btree.FindSecondMax());
        }
    }
}
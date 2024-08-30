using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeTest
{
    public class MirrorTreeTests
    {
        [Fact]
        public void TestMirrorTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(4);
            tree.Root.Left = new Node(8);
            tree.Root.Right = new Node(7);
            tree.Root.Left.Left = new Node(12);
            tree.Root.Left.Right = new Node(9);

            // Act
            List<int> originalInorder = tree.InorderTraversal();
            tree.Mirror();
            List<int> mirroredInorder = tree.InorderTraversal();

            // Assert
            Assert.Equal(new List<int> { 12, 8, 9, 4, 7 }, originalInorder);
            Assert.Equal(new List<int> { 7, 4, 9, 8, 12 }, mirroredInorder);
        }

        [Fact]
        public void TestMirrorSingleNodeTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);

            // Act
            List<int> originalInorder = tree.InorderTraversal();
            tree.Mirror();
            List<int> mirroredInorder = tree.InorderTraversal();

            // Assert
            Assert.Equal(new List<int> { 1 }, originalInorder);
            Assert.Equal(new List<int> { 1 }, mirroredInorder);
        }

        [Fact]
        public void TestMirrorEmptyTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            // Act
            List<int> originalInorder = tree.InorderTraversal();
            tree.Mirror();
            List<int> mirroredInorder = tree.InorderTraversal();

            // Assert
            Assert.Equal(new List<int>(), originalInorder);
            Assert.Equal(new List<int>(), mirroredInorder);
        }
    }
}

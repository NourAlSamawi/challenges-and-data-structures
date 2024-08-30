using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int data)
        {
            Root = AddRecursive(Root, data);
        }

        private Node AddRecursive(Node node, int data)
        {
            if (node == null)
            {
                return new Node(data);
            }

            if (data < node.Data)
            {
                node.Left = AddRecursive(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = AddRecursive(node.Right, data);
            }

            return node;
        }

        public bool Contains(int data)
        {
            return ContainsRecursive(Root, data);
        }

        private bool ContainsRecursive(Node node, int data)
        {
            if (node == null) return false;

            if (data == node.Data) return true;

            return data < node.Data
                ? ContainsRecursive(node.Left, data)
                : ContainsRecursive(node.Right, data);
        }

        public void Remove(int data)
        {
            Root = RemoveRecursive(Root, data);
        }

        private Node RemoveRecursive(Node node, int data)
        {
            if (node == null) return null;

            if (data < node.Data)
            {
                node.Left = RemoveRecursive(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = RemoveRecursive(node.Right, data);
            }
            else
            {
                if (node.Left == null) return node.Right;
                if (node.Right == null) return node.Left;

                node.Data = FindMin(node.Right).Data;
                node.Right = RemoveRecursive(node.Right, node.Data);
            }

            return node;
        }

        private Node FindMin(Node node)
        {
            return node.Left == null ? node : FindMin(node.Left);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node<T>
    {
        private T data; 
        public T Data { get { return data; } set { data = value; } }
        private Node<T> leftChild;
        public Node<T> LeftChild { get { return leftChild; } set { leftChild = value; } }
        private Node<T> rightChild;
        public Node<T> RightChild { get { return rightChild; } set { rightChild = value; } }
        private Node<T> parent;
        public Node<T> Parent { get { return parent; } set { parent = value; } }

        public Node(T data)
        {
            parent = null;
            rightChild = null;
            leftChild = null;
            this.data = data;
        }
        public bool IsParent()
        {
            if (leftChild != null || rightChild != null)
                return true;
            else
                return false;
        }
        public bool IsLeaf()
        {
            if (leftChild == null && rightChild == null)
                return true;
            else
                return false;
        }
        public bool IsRoot()
        {
            if (parent == null)
                return true;
            else
                return false;
        }
        public bool HasRightChild()
        {
            if (rightChild == null)
                return false;
            else
                return true;
        }
        public bool HasLeftChild()
        {
            if (leftChild == null)
                return false;
            else
                return true;
        }
        public bool HasTwoChildren()
        {
            if (leftChild != null && rightChild != null)
                return true;
            else
                return false;
        }
    }
}

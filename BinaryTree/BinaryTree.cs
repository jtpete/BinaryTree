﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree<T>
    {
        private Node<T> root;
        public Node<T> Root { get { return root; } set { root = value; } }
        private int count;
        public int Count { get { return count; } set { count = value; } }

        public BinaryTree()
        {
            root = null;
            count = 0;
        }
        public void Add(T data)
        {
            Node<T> nextNode = new Node<T>(data);
            count += 1;
            if (root == null)
                root = nextNode;
            else
                AddToCorrectNode(root, nextNode);
        }
        private void AddToCorrectNode(Node<T> parent, Node<T> addNode)
        {
            if (Comparer<T>.Default.Compare(parent.Data, addNode.Data) > 0 && !parent.HasLeftChild())
            {
                parent.LeftChild = addNode;
                addNode.Parent = parent;
            }
            else if (Comparer<T>.Default.Compare(parent.Data, addNode.Data) <= 0 && !parent.HasRightChild())
            {
                parent.RightChild = addNode;
                addNode.Parent = parent;
            }
            else if (Comparer<T>.Default.Compare(parent.Data, addNode.Data) == 0 && parent.HasRightChild())
            {
                if (Comparer<T>.Default.Compare(parent.RightChild.Data, addNode.Data) > 0)
                {
                    parent.RightChild.Parent = addNode;
                    parent.RightChild = addNode;
                    addNode.Parent = parent;
                }
                else
                    AddToCorrectNode(parent.RightChild, addNode);
            }
            else if (Comparer<T>.Default.Compare(parent.Data, addNode.Data) > 0)
                AddToCorrectNode(parent.LeftChild, addNode);
            else if (Comparer<T>.Default.Compare(parent.Data, addNode.Data) <= 0)
                AddToCorrectNode(parent.RightChild, addNode);
        }

        public bool Contains(T data)
        {
            if (root == null)
                return false;
            else
                return CheckTreeForContent(root, data);
        }

        private bool CheckTreeForContent(Node<T> parent, T data)
        {
            if (Comparer<T>.Default.Compare(parent.Data, data) == 0)
                return true;
            else if (parent.IsLeaf())
                return false;
            else if (Comparer<T>.Default.Compare(parent.Data, data) > 0 && !parent.HasLeftChild())
                return false;
            else if (Comparer<T>.Default.Compare(parent.Data, data) < 0 && !parent.HasRightChild())
                return false;
            else if (Comparer<T>.Default.Compare(parent.Data, data) > 0)
                return CheckTreeForContent(parent.LeftChild, data);
            else if (Comparer<T>.Default.Compare(parent.Data, data) < 0)
                return CheckTreeForContent(parent.RightChild, data);
            else
                return false;

        }
    }
}

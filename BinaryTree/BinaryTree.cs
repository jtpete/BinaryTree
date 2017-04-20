using System;
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


    }
}

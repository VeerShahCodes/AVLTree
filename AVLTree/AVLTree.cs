using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avlTree
{
    public class AVLTree<T>
        where T : IComparable<T>
    {
        public Node<T> Root;
        public int balance;

        public AVLTree()
        {

        }
        public void Add(T value)
        {
            Node<T> current = Root;

            if (Root == null)
            {
                Root = new Node<T>(value);
                return;
            }


        }

        public void Delete(T value)
        {

        }
    }
}

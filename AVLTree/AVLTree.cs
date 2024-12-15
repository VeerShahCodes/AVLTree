using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    public class AVLTree<T>
        where T : IComparable<T>
    {
        public Node<T> Root;
        public int balance;
        public void Add(T value)
        {
            Node<T> current = Root;
            if(Root == null)
            {
                Root = new Node<T>(value);
            }

        }

        public void Delete(T value)
        {

        }
    }
}

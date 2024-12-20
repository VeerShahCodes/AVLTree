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
        public void Add(T value, Node<T> current)
        {
            
            if (Root == null)
            {
                Root = new Node<T>(value);
                return;
            }

            if(value.CompareTo(current.value) < 0)
            {
                if(current.leftChild != null)
                {
                    Add(value, current.leftChild);
                }
                else
                {
                    current.leftChild = new Node<T>(value);
                    return;
                }
            }
            else
            {
                if(current.rightChild != null)
                {
                    Add(value, current.rightChild);
                }
                else
                {
                    current.rightChild = new Node<T>(value);
                    return;
                }
            }


        }

        public void Delete(T value)
        {

        }
    }
}

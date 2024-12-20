namespace avlTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> avlTree = new AVLTree<int>();

            avlTree.Add(5, avlTree.Root);
            avlTree.Add(7, avlTree.Root);
            avlTree.Add(6, avlTree.Root);
           
        }
    }
}

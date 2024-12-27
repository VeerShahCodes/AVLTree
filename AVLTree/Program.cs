namespace avlTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> avlTree = new AVLTree<int>();

            avlTree.Add(5);
            avlTree.Add(6);
            avlTree.Add(7);
            avlTree.Add(8);
            avlTree.Add(9);
           avlTree.DepthFirstTraversal(avlTree.Root);
        }
    }
}

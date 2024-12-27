namespace avlTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> avlTree = new AVLTree<int>();

            avlTree.Add(30);
            avlTree.Add(20);
            avlTree.Add(25);

           avlTree.DepthFirstTraversal(avlTree.Root);
        }
    }
}

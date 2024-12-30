namespace avlTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> avlTree = new AVLTree<int>();
            avlTree.Add(5);
            avlTree.Add(6);
            avlTree.Delete(6);

            avlTree.BreadthFirstTraversal(avlTree.Root);
        }
    }
}

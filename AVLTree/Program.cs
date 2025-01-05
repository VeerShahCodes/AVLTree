namespace avlTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> avlTree = new AVLTree<int>();
            avlTree.Add(30);
            avlTree.Add(15);
            avlTree.Add(25);
            avlTree.Delete(15);
            avlTree.Add(35);
            avlTree.Delete(25);
            avlTree.Add(40);
            avlTree.Delete(35);
            avlTree.Add(10);
            avlTree.Add(50);


            Console.WriteLine("Pre Order Traversal: ");
            avlTree.PreOrderTraversal(avlTree.Root);
            Console.WriteLine();
            Console.WriteLine("Post Order Traversal: ");
            avlTree.PostOrderTraversal(avlTree.Root);
            Console.WriteLine();
            Console.WriteLine("In Order Traversal: ");
            avlTree.InOrderTraversal(avlTree.Root);
        }
    }
}

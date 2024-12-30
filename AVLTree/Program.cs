namespace avlTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> avlTree = new AVLTree<int>();
            avlTree.Add(10);  // Add root
            avlTree.Add(15);  // Add right child to root
            avlTree.Add(5);   // Add left child to root
            avlTree.Add(12);  // Add left child to 15
            avlTree.Add(18);  // Add right child to 15
            avlTree.Delete(15); // Delete a node with two children (12 replaces 15)

            avlTree.Add(3);   // Add left child to 5
            avlTree.Add(7);   // Add right child to 5
            avlTree.Add(6);   // Add left child to 7
            avlTree.Delete(10); // Delete the root node (7 becomes the new root after balancing)

            avlTree.Add(20);  // Add right child to 18
            avlTree.Add(17);  // Add left child to 18
            avlTree.Delete(5); // Delete a node with two children (3 replaces 5)
            avlTree.Delete(6); // Delete a leaf node
            avlTree.Add(4);   // Add left child to 7
            Console.WriteLine("Pre Order Traversal: ");
            avlTree.PreOrderTraversal(avlTree.Root);
            Console.WriteLine();
            Console.WriteLine("Post Order Traversal: ");
            avlTree.PostOrderTraversal(avlTree.Root);
        }
    }
}

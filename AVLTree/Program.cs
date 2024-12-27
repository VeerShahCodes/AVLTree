namespace avlTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> avlTree = new AVLTree<int>();
            Random random = new Random();

            Console.WriteLine("Before:");
            for(int i = 0; i < 10; i++)
            {
                int rand = random.Next(11);
                Console.WriteLine(rand);
                avlTree.Add(rand);
            }


            avlTree.BreadthFirstTraversal(avlTree.Root);
        }
    }
}

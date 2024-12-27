namespace avlTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> avlTree = new AVLTree<int>();
            Random random = new Random();
            List<int> list = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                int val = random.Next(11);
                Console.WriteLine(val);
                avlTree.Add(random.Next(11));
                
            }
          

           avlTree.DepthFirstTraversal(avlTree.Root);
        }
    }
}

namespace SortedDoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SortedDoublyLinkedList<int> linkedList = new SortedDoublyLinkedList<int>(5);
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                linkedList.Insert(random.Next(100));
            }

            linkedList.WriteNodes();
        }
    }
}

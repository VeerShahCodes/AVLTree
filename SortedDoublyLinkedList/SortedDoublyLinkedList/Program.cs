namespace SortedDoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SortedDoublyLinkedList<int> linkedList = new SortedDoublyLinkedList<int>();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                linkedList.Add(random.Next(100));
            }

            linkedList.PrintList();
        }
    }
}

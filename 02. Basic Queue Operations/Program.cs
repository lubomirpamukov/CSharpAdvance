namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numbersToAdd = data[0];
            int numbersToRemove = data[1];
            int numberToFind = data[2];

            Queue<int> queue = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .Take(numbersToAdd - numbersToRemove));

            if (queue.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(numberToFind))
            {
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
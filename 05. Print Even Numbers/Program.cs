namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            List<int> result = new List<int>();

            foreach (int number in numbers) 
            {
                queue.Enqueue(number);
            }

            while (queue.Count > 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                    result.Add(queue.Dequeue());
                }
                else 
                {
                    queue.Dequeue();
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
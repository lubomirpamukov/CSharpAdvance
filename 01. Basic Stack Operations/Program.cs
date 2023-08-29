namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberOfElementsToPush = data[0];
            int numberOfElementsToPop = data[1];
            int numberToFindInStack = data[2];

            Stack<int> stack = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(numberOfElementsToPush - numberOfElementsToPop));

            if (stack.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(numberToFindInStack))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine($"{stack.Min()}");
            }

            Console.ReadLine();
        }
    }
}
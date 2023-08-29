namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Queue<string> kids = new Queue<string>(input);
            int nthKid = int.Parse(Console.ReadLine());

            while (true)
            {
                if (kids.Count == 1)
                {
                    break;
                }
                for (int i = 0; i < nthKid - 1; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");
            }
            Console.WriteLine($"Last is {kids.Peek()}");
        }
        
    }
}
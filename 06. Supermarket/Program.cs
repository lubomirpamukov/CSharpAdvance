namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                if (command != "Paid")
                {
                    customers.Enqueue(command);
                }
                else if (command == "Paid") 
                {
                    while (customers.Count > 0) 
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
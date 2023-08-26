namespace _02.Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            string command;
            Stack<int> intStack = new Stack<int>();
            
            foreach (int number in numbers) 
            {
                intStack.Push(number);
            }
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = command.Split();
                string commandType = cmdArgs[0];

                if (commandType == "add")
                {
                    int firstNumber = int.Parse(cmdArgs[1]);
                    int secondNumber = int.Parse(cmdArgs[2]);
                    intStack.Push(firstNumber);
                    intStack.Push(secondNumber);
                }
                else
                {
                    int numberToRemove = int.Parse(cmdArgs[1]);

                    if (intStack.Count >= numberToRemove)
                    {
                        for (int i = 0; i < numberToRemove; i++)
                        {
                            intStack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {intStack.Sum()}");
            Console.WriteLine();
        }
    }
}
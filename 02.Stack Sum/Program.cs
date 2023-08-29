namespace _02.Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine() // making int array that reeads input from the console
                 .Split() // splits the input by " "
                 .Select(int.Parse) //converts each elements from string to int
                 .ToArray(); // writes them into an array
            Stack<int> intStack = new Stack<int>(); // creating empty stack
            
            foreach (int number in numbers) // iterates through each element in the numbers array
            {
                intStack.Push(number); // adding the element to the stack
            }

            string command; // initialize empty string
            while ((command = Console.ReadLine().ToLower()) != "end")// iterates until end command is given
            {
                string[] cmdArgs = command.Split();// splits the command into separate by " " elements
                string commandType = cmdArgs[0];// creating variable with command type for easy readability

                if (commandType == "add")// if command is add
                {
                    int firstNumber = int.Parse(cmdArgs[1]); // converts the string element to int
                    int secondNumber = int.Parse(cmdArgs[2]); // -''-
                    intStack.Push(firstNumber); //adds new data to the stack
                    intStack.Push(secondNumber);// adds new data to stack
                }
                else // if command is remove
                {
                    int numberToRemove = int.Parse(cmdArgs[1]);// converts the string element to int element

                    if (intStack.Count >= numberToRemove) // checks if there enought numbers in the stack to remove succesfully
                    {
                        for (int i = 0; i < numberToRemove; i++) // if there are iterates throug them
                        {
                            intStack.Pop();// delete current element
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {intStack.Sum()}"); // print the leftover total sum of all the elements left in the stack
        }
    }
}
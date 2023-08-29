namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(); //reads string elements from the console and splits them in array
            Stack<string> stack = new Stack<string>(input.Reverse());// making a stack and filling it with the elements in reverse order
            double result = double.Parse(stack.Pop());// remnoves 1 element from the stack and converts it into int and saves it in reuslts

            while (stack.Count > 0) // while count is >0 iterates
            {
                string operation = stack.Pop();// remove 1 item from the stack and saves it into operation variable
                double number = double.Parse(stack.Pop());// remove 1 item from the stack and saves it as double in a variable

                if (operation == "+")// if operation is "+"
                {
                    result += number; // adds the number to the result
                }
                else if (operation == "-") // if operation is "-"
                {
                    result -= number; // subtracts the number from the result
                }
            }

            Console.WriteLine(result); // prints the end result
        }
    }
    
}
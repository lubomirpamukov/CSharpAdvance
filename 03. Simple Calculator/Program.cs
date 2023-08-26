namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split();

            Stack<string> stack = new Stack<string>(tokens.Reverse());

            double result = double.Parse(stack.Pop());

            while (stack.Count > 0)
            {
                string operation = stack.Pop();
                double number = double.Parse(stack.Pop());

                if (operation == "+")
                {
                    result += number;
                }
                else if (operation == "-")
                {
                    result -= number;
                }
            }

            Console.WriteLine(result);
        }
    }
    
}
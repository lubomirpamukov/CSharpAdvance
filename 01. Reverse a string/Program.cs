namespace _01._Reverse_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToArray(); // reads array of chars as input
            Stack<char> stack = new Stack<char>(); // creating stack of chars
            
            foreach (char c in input) // itterating thorug every char in the input array
            {
                stack.Push(c); // adds every char into the stack
            }

            while (stack.Count > 0) // itterating until stack is empty
            {
                Console.Write(stack.Pop()); // prints on the console and removes each char
            }
        }
    }
}
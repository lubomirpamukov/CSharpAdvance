namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> openingBracket = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openingBracket.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = openingBracket.Pop();
                    int endIndex = i;
                    string subString = input.Substring(startIndex, endIndex - startIndex+1);
                    Console.WriteLine(subString);
                }
            }
        }
    }
}


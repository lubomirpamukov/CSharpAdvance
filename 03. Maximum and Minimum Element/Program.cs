using System.Collections.Concurrent;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfQuerys = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();    

            for (int query = 0; query < numberOfQuerys; query++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int queryType = data[0];

                if (queryType == 1)
                {
                    int elementToAdd = data[1];
                    stack.Push(elementToAdd);
                }
                else if (queryType == 2)
                {
                    stack.Pop();
                }
                else if (queryType == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (queryType == 4) 
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
            Console.ReadLine();
        }
    }
}
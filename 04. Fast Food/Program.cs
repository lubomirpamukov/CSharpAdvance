namespace _04._Fast_Food;
class Program
{
    static void Main(string[] args)
    {
        int totalResturantFood = int.Parse(Console.ReadLine());
        Queue<int> foodQuerys = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
        Console.WriteLine(foodQuerys.Max()); // prints the biggest client

        while (foodQuerys.Count > 0)
        {
            if (foodQuerys.Peek() <= totalResturantFood)
            {
                totalResturantFood -= foodQuerys.Dequeue();
            }
            else 
            {
                break;
            }
        }

        if (foodQuerys.Count > 0)
        {
            Console.WriteLine(string.Join(" ", foodQuerys));
        }
        else 
        {
            Console.WriteLine("Orders complete");
        }

        Console.ReadLine();
    }
}

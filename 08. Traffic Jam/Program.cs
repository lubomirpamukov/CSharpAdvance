namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsPassingOnGreen = int.Parse(Console.ReadLine());
            string command = string.Empty;
            Queue<string> carModel = new Queue<string>();
            int carsPassedCounter = default;
            
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    //remove N number of cars passing on green + text model + Passed and count the cars
                    for (int i = 0; i < numberOfCarsPassingOnGreen; i++)
                    {
                        if (carModel.Count <= 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{carModel.Dequeue()} passed!");
                        carsPassedCounter++;
                    }
                }
                else 
                {
                    //add the model to the queue
                    carModel.Enqueue(command);
                }
            }

            //print "{number of cars} cars passed the crossroads.".
            Console.WriteLine($"{carsPassedCounter} cars passed the crossroads.");
            Console.ReadLine();
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        int greenLightCars = int.Parse(Console.ReadLine());
        Queue<string> cars = new Queue<string>();
        string input;
        int passedCars = 0;
        while((input = Console.ReadLine()) != "end")
        {
            if (input == "green")
            {
                for (int i = 0; i < greenLightCars; i++)
                {
                    if (cars.Count <= 0)
                    {
                        break;
                    }
                    string currentCar = cars.Dequeue();
                    Console.WriteLine($"{currentCar} passed!");
                    passedCars++;
                }
                continue;
            }
            cars.Enqueue(input);
        }
        Console.WriteLine($"{passedCars} cars passed the crossroads.");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Queue<string> names = new Queue<string>(Console.ReadLine().Split());
        int numberOfTosses = int.Parse(Console.ReadLine());
        int currentTosses = 0;
        while (names.Count > 1) 
        {
            currentTosses++;
            string currentName = names.Dequeue();
            if (currentTosses == numberOfTosses)
            {
                Console.WriteLine($"Removed {currentName}");
                currentTosses = 0;
                continue;
            }
            names.Enqueue(currentName);
        }
        Console.WriteLine($"Last is {names.Last()}");
    }
}
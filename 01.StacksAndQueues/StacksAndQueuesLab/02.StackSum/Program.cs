internal class Program
{
    static void Main(string[] args)
    {
        Stack<int> numbers = new Stack<int>
            (Console.ReadLine()
            .Split()
            .Select(x => int.Parse(x)));
        string input;
        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            string[] tokens = input.Split(' ');
            switch (tokens[0].ToLower())
            {
                case "add":
                    numbers.Push(int.Parse(tokens[1]));
                    numbers.Push(int.Parse(tokens[2]));
                    break;
                case "remove":
                    if (!(int.Parse(tokens[1]) > numbers.Count))
                    {
                        for (int i = 0; i < int.Parse(tokens[1]); i++)
                        {
                            numbers.Pop();
                        }
                    }
                    break;
            }
        }
        Console.WriteLine($"Sum: {numbers.Sum(x => x)}");
    }
}
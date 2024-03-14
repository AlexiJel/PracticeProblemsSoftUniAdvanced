using System;

internal class Program
{
    static void Main(string[] args)
    {
        Stack<string> strings = new Stack<string>(Console.ReadLine()
            .Split(" ")
            .ToArray().
            Reverse());
        int sum = 0;
        while (strings.Count > 0)
        {
            string currentString= strings.Pop();
            if (currentString == "-")
            {
                sum -= int.Parse(strings.Pop().ToString());
            }
            else if (currentString == "+")
            {
                sum += int.Parse(strings.Pop().ToString());
            }
            else
            {
                sum += int.Parse(currentString.ToString());
            }
        }
        Console.WriteLine(sum);
    }
}
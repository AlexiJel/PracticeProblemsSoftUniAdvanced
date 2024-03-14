﻿internal class Program
{
    static void Main(string[] args)
    {
        Queue<int> evenNumbers = new Queue<int>(Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Where(x => x % 2 == 0));
        Console.WriteLine(string.Join(", ",evenNumbers));
    }
}
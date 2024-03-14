internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Stack<char> sentence = new Stack<char>(input);
        while (sentence.Count > 0)
        {
            Console.Write(sentence.Pop());
        }
    }
}
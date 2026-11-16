namespace Arrays_Homework_2;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] names = input.Split(' ');

        foreach (string name in names)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
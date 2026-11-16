    namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        
        string input = Console.ReadLine();
        string[] stringArray = input.Split(' ');
        int[] numbers = Array.ConvertAll(stringArray, int.Parse);
        int daysBelowZero = 0;
        int warmest = numbers[0];
        int coldest = numbers[0];

        foreach (int number in numbers)
        {
            if (number < 0)
            {
                daysBelowZero++;
            }

            if (number > warmest)
            {
                warmest = number;
            }

            if (number < coldest)
            {
                coldest = number;
            }
        }
        Console.WriteLine($"Days below zero: {daysBelowZero}");
        Console.WriteLine($"Warmest: {warmest}");
        Console.WriteLine($"Coldest: {coldest}");

    }
}
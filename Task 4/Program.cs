namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        string rawInput = Console.ReadLine();
        string[] stringArray = rawInput.Split(' ');
        int[] numberArray = Array.ConvertAll(stringArray, int.Parse);
        int biggerOnLeft = 0;

        for (int i = 0; i < numberArray.Length - 1; i++)
        {
            if (numberArray[i] > numberArray[i + 1])
            {
                Console.WriteLine($"{numberArray[i]} > {numberArray[i + 1]}");
                biggerOnLeft++;
            }
            else if (numberArray[i] < numberArray[i + 1])
            {
                Console.WriteLine($"{numberArray[i]} < {numberArray[i + 1]}");
            }
            else
            {
                Console.WriteLine($"{numberArray[i]} = {numberArray[i + 1]}");
            }
        }
        Console.WriteLine($"Bigger on the left: {biggerOnLeft}");
    }
}
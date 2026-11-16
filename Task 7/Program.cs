namespace Task_7;

class Program
{
    static void Main(string[] args)
    {
        string rawInput = Console.ReadLine();
        string[] stringArray = rawInput.Split(' ');
        int[] numberArray = Array.ConvertAll(stringArray, int.Parse);
        int swaps = 0;

        for (int i = 0; i < numberArray.Length - 1; i++)
        {
            if (numberArray[i] > numberArray[i + 1])
            {
                int temp = numberArray[i];
                numberArray[i] = numberArray[i + 1];
                numberArray[i + 1] = temp;

                swaps++;
            }
        } 
        Console.WriteLine(string.Join(" ", numberArray));
        Console.WriteLine(swaps);
    }
}
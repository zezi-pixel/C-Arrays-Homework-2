namespace Task_6;

class Program
{
    static void Main(string[] args)
    {
        string rawInput = Console.ReadLine();
        string[] stringArray = rawInput.Split(' ');
        int[] numberArray = Array.ConvertAll(stringArray, int.Parse);

        for (int i = 0; i < numberArray.Length / 2; i++)
        {
            int temp = numberArray[i];
            numberArray[i] = numberArray[numberArray.Length - 1 - i];
            numberArray[numberArray.Length - 1 - i] = temp;
        }
        Console.WriteLine(string.Join(" ", numberArray));
    }
}
namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        string rawInput = Console.ReadLine();
        string[] stringArray = rawInput.Split(' ');
        int[] numberArray = Array.ConvertAll(stringArray, int.Parse);
        Console.WriteLine(string.Join(" ", numberArray));

        int temp = numberArray[0];
        numberArray[0] = numberArray[numberArray.Length - 1];
        numberArray[numberArray.Length - 1] = temp;
        Console.WriteLine(string.Join(" ", numberArray));

        temp = numberArray[1];
        numberArray[1] = numberArray[3];
        numberArray[3] = temp;
        Console.WriteLine(string.Join(" ", numberArray));
    }
}
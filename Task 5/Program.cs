namespace Task_5;

class Program
{
    static void Main(string[] args)
    {
        string rawInput = Console.ReadLine();
        string[] stringArray = rawInput.Split(' ');
        int[] numberArray = Array.ConvertAll(stringArray, int.Parse);
            bool isSorted = true;

        for (int i = 0; i < numberArray.Length - 1; i++)
        {
            if (numberArray[i] > numberArray[i + 1])
            {
                isSorted = false;
                break;
            }
        }

        if (isSorted)
        {
            Console.WriteLine("Sorted");
        }
        else
        {
            Console.WriteLine("Not sorted");
        }
    }
}
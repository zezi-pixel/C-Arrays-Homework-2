namespace Task_8;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] stringArray = input.Split(' ');
        int[] numbers = Array.ConvertAll(stringArray, int.Parse);
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int a = i + 1; a < numbers.Length; a++)
            {
                if (numbers[i] > numbers[a])
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}
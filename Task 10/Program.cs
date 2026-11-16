namespace Task_10;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] stringArray = input.Split(' ');
        int[] numbers = Array.ConvertAll(stringArray, int.Parse);

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            bool swapped = false;

            for (int a = 0; a < numbers.Length - i - 1; a++)
            {
                if (numbers[a] > numbers[a + 1])
                { 
                    int temp = numbers[a];
                    numbers[a] = numbers[a + 1];
                    numbers[a + 1] = temp;
                    swapped = true;
                }
            }
            if (swapped == false)
            {
                break;
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
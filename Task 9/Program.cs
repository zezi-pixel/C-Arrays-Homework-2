namespace Task_9;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] stringArray = input.Split(' ');
        int[] numbers = Array.ConvertAll(stringArray, int.Parse);
        int k = int.Parse(Console.ReadLine());

        for (int rotation = 0; rotation < k; rotation++)
        {
            int firstNumber = numbers[0];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = firstNumber;
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
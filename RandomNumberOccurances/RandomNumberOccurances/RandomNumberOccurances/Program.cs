namespace RandomNumberOccurences
{
    internal class Program
    {
        static void Main()
        {
            Random randomNumber = new Random();
            int[] randomArray = new int[100];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = randomNumber.Next(20, 41);
            }

            int[] numberOcurances = new int[21];

            foreach (var number in randomArray)
            {
                numberOcurances[number - 20]++;
            }

            for (int i = 0; i < numberOcurances.Length; i++)
            {
                if (numberOcurances[i] > 0)
                {
                    Console.WriteLine($"{i + 20}: {numberOcurances[i]} times");
                }
            }
        }
    }
}
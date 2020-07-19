namespace NestedLoopsMoreExercise
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int biggestFirstNumber = int.Parse(Console.ReadLine());
            int biggestSecondNumber = int.Parse(Console.ReadLine());
            int biggestThirdNumber = int.Parse(Console.ReadLine());

            int firstNumber = 2;
            int secondNumber = 2;
            int thirdNumber = 2;


            for (int i = 2; i <= biggestFirstNumber; i++)
            {
                if (i % 2 == 0)
                {
                    firstNumber = i;

                    for (int j = 2; j <= biggestSecondNumber; j++)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            secondNumber = j;

                            for (int k = 2; k <= biggestThirdNumber; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    thirdNumber = k;

                                    Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber}");
                                }

                            }
                        }
                    }
                }
            }

        }
    }
}

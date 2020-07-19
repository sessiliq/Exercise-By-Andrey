namespace CatWalking
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int caloriesPerMinute = 5;

            int minutesPerWalk = int.Parse(Console.ReadLine());
            int walksCount = int.Parse(Console.ReadLine());
            int caloriesEaten = int.Parse(Console.ReadLine());

            int totalMinutesWalkPerDay = walksCount * minutesPerWalk;
            int totalCaloriesBurnt = totalMinutesWalkPerDay * caloriesPerMinute;

            if (totalCaloriesBurnt >= caloriesEaten / 2.0)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCaloriesBurnt}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCaloriesBurnt}.");
            }
        }
    }
}

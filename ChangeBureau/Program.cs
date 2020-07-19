namespace ChangeBureau
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double chinaUans = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double bitcoinInBgn = bitcoins * 1168;
            double chinaUansInBgn = (chinaUans * 0.15) * 1.76;

            var totalMoneyInEur = (bitcoinInBgn + chinaUansInBgn) / 1.95;

            totalMoneyInEur *= 1 - (comission / 100.0);

            Console.WriteLine($"{totalMoneyInEur:F2}");
        }
    }
}

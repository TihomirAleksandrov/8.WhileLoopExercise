using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int coinsCounter = 0;

            while (change > 0)
            {
                change = Math.Round(change, 2);

                if (change >= 2)
                {
                    change = change - 2;
                    coinsCounter++;
                }
                else if (change >= 1)
                {
                    change = change - 1;
                    coinsCounter++;
                }
                else if (change >= 0.50)
                {
                    change -= 0.50;
                    coinsCounter++;
                }
                else if (change >= 0.20)
                {
                    change -= 0.20;
                    coinsCounter++;
                }
                else if (change >= 0.10)
                {
                    change -= 0.10;
                    coinsCounter++;
                }
                else if (change >= 0.05)
                {
                    change -= 0.05;
                    coinsCounter++;
                }
                else if (change >= 0.02)
                {
                    change -= 0.02;
                    coinsCounter++;
                }
                else if (change >= 0.01)
                {
                    change -= 0.01;
                    coinsCounter++;
                }
            }
            Console.WriteLine(coinsCounter);
        }
    }
}

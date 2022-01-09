using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double moneySaved = double.Parse(Console.ReadLine());
            int dayCounter = 0;
            int spendingcounter = 0;
            bool isSpent = false;

            while (moneySaved < vacationPrice)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    spendingcounter++;
                    dayCounter++;
                    moneySaved -= money;

                    if (spendingcounter == 5)
                    {
                        isSpent = true;
                        break;
                    }
                    else if (moneySaved < 0)
                    {
                        moneySaved = 0;
                    }
                }
                else
                {
                    spendingcounter = 0;
                    dayCounter++;
                    moneySaved += money;
                }
            }

            if (isSpent)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(dayCounter);
            }
            else
            {
                Console.WriteLine($"You saved the money for {dayCounter} days.");
            }
        }
    }
}

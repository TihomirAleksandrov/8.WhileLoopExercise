using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            int stepsDifference = 0;
            bool isGoingHome = false;
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    isGoingHome = true;
                    break;
                }

                int steps = int.Parse(input);
                totalSteps += steps;
                
                if (totalSteps >= 10000)
                {
                    break;
                }
            }

            if (isGoingHome)
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                stepsDifference = ((totalSteps + stepsToHome) - 10000);

                if (stepsDifference >= 0)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsDifference} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(stepsDifference)} more steps to reach goal.");
                }
            }
            else
            {
                stepsDifference = totalSteps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsDifference} steps over the goal!");
            }
        }
    }
}

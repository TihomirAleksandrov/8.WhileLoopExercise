using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int cakePieces = cakeLength * cakeWidth;
            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int cakeTaken = int.Parse(input);
                cakePieces -= cakeTaken;

                if (cakePieces < 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (cakePieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
        }
    }
}

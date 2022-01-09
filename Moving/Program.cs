using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomWidth = int.Parse(Console.ReadLine());
            int roomLength = int.Parse(Console.ReadLine());
            int roomHeight = int.Parse(Console.ReadLine());
            int roomVolume = roomHeight * roomLength * roomWidth;
            string input = Console.ReadLine();

            while (input != "Done")
            {
                int boxesNum = int.Parse(input);
                roomVolume -= boxesNum;

                if (roomVolume < 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (roomVolume < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(roomVolume)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{roomVolume} Cubic meters left.");
            }
        }
    }
}

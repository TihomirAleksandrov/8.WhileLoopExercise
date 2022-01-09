using System;

namespace WhileLoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int counter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }
                else if (input == bookName)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }

                counter++;
            }
        }
    }
}

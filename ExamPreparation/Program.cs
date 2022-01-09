using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int badGradeCounter = 0;
            int problemCounter = 0;
            string lastProblem = "";
            double totalGrade = 0;
            double averageGrade = 0;
            bool isEnough = false;

            while (true)
            {
                string problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    isEnough = true;
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                totalGrade += grade;

                if (grade <= 4)
                {
                    badGradeCounter++;

                    if (badGradeCounter == badGrades)
                    {
                        break;
                    }

                }
                
                lastProblem = problemName;
                problemCounter++;
            }

            averageGrade = totalGrade / problemCounter;

            if (isEnough)
            {
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {problemCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badGradeCounter} poor grades.");
            }
        }
    }
}

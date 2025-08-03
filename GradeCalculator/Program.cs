using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your numerical grade (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                    return;
                }

                if (grade >= 90)
                    Console.WriteLine("Your grade is: A");
                else if (grade >= 80)
                    Console.WriteLine("Your grade is: B");
                else if (grade >= 70)
                    Console.WriteLine("Your grade is: C");
                else if (grade >= 60)
                    Console.WriteLine("Your grade is: D");
                else
                    Console.WriteLine("Your grade is: F");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}

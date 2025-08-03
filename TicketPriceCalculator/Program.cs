using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age <= 12 || age >= 65)
                    Console.WriteLine("Your ticket price is: GHC7");
                else
                    Console.WriteLine("Your ticket price is: GHC10");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}

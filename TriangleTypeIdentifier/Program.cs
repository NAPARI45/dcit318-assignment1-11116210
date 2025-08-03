using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of side 1: ");
            bool isSide1Valid = double.TryParse(Console.ReadLine(), out double side1);
            Console.Write("Enter length of side 2: ");
            bool isSide2Valid = double.TryParse(Console.ReadLine(), out double side2);
            Console.Write("Enter length of side 3: ");
            bool isSide3Valid = double.TryParse(Console.ReadLine(), out double side3);

            if (!isSide1Valid || !isSide2Valid || !isSide3Valid)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
                return;
            }

            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("All sides must be greater than 0.");
                return;
            }

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                Console.WriteLine("These sides do not form a valid triangle.");
                return;
            }

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is Equilateral.");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("The triangle is Isosceles.");
            else
                Console.WriteLine("The triangle is Scalene.");
        }
    }
}

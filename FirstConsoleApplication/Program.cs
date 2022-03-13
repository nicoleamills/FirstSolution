using System;

namespace TwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result; // variables

            // read user input numbers and convert to integers
            Console.Write("Please enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Select an mathematical operation
            Console.WriteLine("Select an operation: 1. Addition, 2. Subtraction, or 3. Multiplication: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            // Math operation selection
            if (operation == 1)
            {
                result = num1 + num2;
                Console.WriteLine("Addition selected. Sum = " + result.ToString());
            }

            else if (operation == 2)
            {
                result = num1 - num2;
            }

            else if (operation == 3)
            {
                result = num1 * num2;
            }

            else
                Console.Write("Invalid input.");
            Console.ReadLine();
        }
    }
}
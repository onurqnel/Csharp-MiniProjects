/*
 * Project: C# Mini Projects
 * Author: Onur Onel
 * Date: October 5, 2024
 * Description: This is a basic calculator program that takes two numbers and an operation 
 *              (addition, subtraction, multiplication, or division) as input, validates the input, 
 *              and performs the operation. The program handles errors like invalid input format 
 *              and division by zero.
 */

public static class Program
{
    public static void Main()
    {
        // Create instances of InputHandler and Calculator
        InputHandler inputHandler = new();
        Calculator calculator = new();

        // Clear the console screen before starting
        Console.Clear();

        try
        {
            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            inputHandler.FirstNumber = Convert.ToDouble(Console.ReadLine());
            double first = inputHandler.FirstNumber;

            // Prompt the user to enter the operation (+, -, *, /)
            Console.Write("Enter an operation (+, -, *, /): ");
            inputHandler.Operation = Convert.ToChar(Console.ReadLine());
            char operation = inputHandler.Operation;

            // Validate if the entered operation is correct
            if (!inputHandler.ValidateOperation(operation))
            {
                Console.WriteLine("Error: Invalid operation.");
                return; // Exit the program if the operation is invalid
            }

            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            inputHandler.SecondNumber = Convert.ToDouble(Console.ReadLine());
            double second = inputHandler.SecondNumber;

            // Perform the operation using the Calculator and print the result
            double result = calculator.PerformOperation(first, operation, second);
            Console.WriteLine("{0} {1} {2} = {3}", first, operation, second, result);
        }
        catch (FormatException)
        {
            // Catch format exceptions (e.g., if the input is not a number)
            Console.WriteLine("Error: Invalid input format.");
        }
        catch (OverflowException)
        {
            // Catch overflow exceptions (e.g., if the input number is too large)
            Console.WriteLine("Error: Input number is too large.");
        }
    }
}

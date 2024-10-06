public class Calculator
{
    // This method performs a mathematical operation on two numbers (num1 and num2)
    // based on the operation provided ('+', '-', '*', or '/').
    public double PerformOperation(double num1, char operation, double num2)
    {
        // Switch statement to determine which operation to perform
        switch (operation)
        {
            case '+':
                // Perform addition
                return num1 + num2;
            case '-':
                // Perform subtraction
                return num1 - num2;
            case '*':
                // Perform multiplication
                return num1 * num2;
            case '/':
                // Check if the second number is zero to avoid division by zero
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero.");
                    return 0; // Return 0 as a fallback value in case of division by zero
                }
                // Perform division
                return num1 / num2;
        }
        // If no valid operation is provided, return 0
        return 0;
    }
}

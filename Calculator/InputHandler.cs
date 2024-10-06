public class InputHandler
{
    // Private fields to store the first number, second number, and the operation
    private double _firstNumber;
    private double _secondNumber;
    private char _operation;

    // Public property to get or set the first number
    public double FirstNumber
    {
        get => _firstNumber;
        set => _firstNumber = value;
    }

    // Public property to get or set the second number
    public double SecondNumber
    {
        get => _secondNumber;
        set => _secondNumber = value;
    }

    // Public property to get or set the mathematical operation
    public char Operation
    {
        get => _operation;
        set => _operation = value;
    }

    // Method to validate if the provided operation is a valid one
    // It checks if the operation is one of the following: +, -, *, /
    public bool ValidateOperation(char operation)
    {
        // Array of valid operations
        char[] validOps = { '+', '-', '*', '/' };
        // Return true if the provided operation exists in the array, otherwise false
        return validOps.Contains(operation);
    }
}

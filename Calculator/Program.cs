using System.ComponentModel.Design;
using System.Xml.Serialization;

CalculatorApp();

void CalculatorApp()
{
    try
    {
        //promt user to enter first number
        Console.WriteLine("Enter the first number:");
        int numOne = Convert.ToInt32(Console.ReadLine());

        //prompt user to enter the second number
        Console.WriteLine("Enter the second number:");
        int numTwo = Convert.ToInt32(Console.ReadLine());

        //prompt user to enter the operation
        Console.WriteLine("Enter the operation (+, -, *, /)");

        /*keyboard is 'string' by defualt
         * it needs to be switched to char using a switch op
         */
        char operation = Convert.ToChar(Console.ReadLine());
        int result = 0;

        //performing the operation
        switch (operation)
        {
            case '+':
                result = numOne + numTwo;
                break;
            case '-':
                result = numOne - numTwo;
                break;
            case '*':
                result = numOne * numTwo;
                break;
            case '/':
                result = numOne / numTwo;
                break;
            default:
                Console.WriteLine("invalid operation.");
                return;
        }
        //output the result to the user
        Console.WriteLine($"Result: {result}");
    }
    catch (FormatException ex) 
    {
        //here is where the program deals with invalid inputs.
        Console.WriteLine("Please enter a valid number.");
    }
    catch (DivideByZeroException ex)
    {
        //this handles when the user tries to times by 0
        Console.WriteLine($"You cannot divide by zero.");
    }
    finally
    {
       //this runs no matter what
       Console.WriteLine("Operation completed.");
    }
}


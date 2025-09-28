using System.ComponentModel.Design;
using System.Xml.Serialization;

CalculatorApp();

void CalculatorApp()
{
    //declare the variables and initialise them to 0
    int numOne = 0;
    int numTwo = 0;
    int result = 0;
    int choice = 0;
    //we will ask the user to input the numbers.
    //two variables which will store the two numbers for the calc.
    Console.WriteLine("Type in the 1st number followed by the enter key");
    numOne = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Type in the 2nd number followed by the enter key");
    numTwo = Convert.ToInt32(Console.ReadLine());

    //make a loop to make the relevant decision
    //perform the requested maths operation
    Console.WriteLine("Choose and option from the following list:");
    Console.WriteLine("1 - add");
    Console.WriteLine("2 - subtract");
    Console.WriteLine("3 - divide");
    Console.WriteLine("4 - multiply");
    //convert string to int
    choice = Convert.ToInt32(Console.ReadLine());

    //if statment to perform selected maths op
    if (choice == 1)
    {
        result = numOne + numTwo;
        Console.WriteLine($"Adding {numOne} and {numTwo} equals {result}");
    }
    else if (choice == 2)
    {
        result = numOne - numTwo;
        Console.WriteLine($"Subtracting {numOne} and {numTwo} equals {result}");
    }
    else if (choice == 3)
    {
        result = numOne / numTwo;
        Console.WriteLine($"Dividing {numOne} and {numTwo} equals {result}");
    }
    else if (choice == 4)
    {
        result = numOne * numTwo;
        Console.WriteLine($"Multiplying {numOne} and {numTwo} equals {result}");
    }
    else 
    {
        Console.WriteLine("You did not select a valid number between 1-4.");
    }
        //this next line displays the result
        Console.WriteLine("The result is {0}", result);
    Console.ReadKey();
}


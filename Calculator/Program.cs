//we will ask the user to input the numbers.
//two variables which will store the two numbers for the calc.
Console.WriteLine("Type in the 1st number followed by the enter key");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in the 2nd number followed by the enter key");
int numTwo = Convert.ToInt32(Console.ReadLine());

//the next variable is result, this will contain the sum of numOne and numTwo.
int result = numOne + numTwo;
//this next line displays the result
Console.WriteLine("The addition of both numebers is {0}", result);
Console.ReadKey();



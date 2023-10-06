using System.Numerics;

Console.WriteLine("Hello");
Console.WriteLine("Input the first number:");
var userInputFirstNumber = Console.ReadLine();
int firstNumber = int.Parse(userInputFirstNumber);

Console.WriteLine("Input the second number:");
var userInputSecondNumber = Console.ReadLine();
int secondNumber = int.Parse(userInputSecondNumber);


Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
var userInputSelectedOption = Console.ReadLine();


if (CompareCaseSensitive(userInputSelectedOption, "A"))
{
    var sum = firstNumber + secondNumber;
    PrintCalculatedEquation(firstNumber, secondNumber, "+", sum);
}
else if (CompareCaseSensitive(userInputSelectedOption, "S"))
{
    var substraction = firstNumber - secondNumber;
    PrintCalculatedEquation(firstNumber, secondNumber, "-", substraction);
}
else if (CompareCaseSensitive(userInputSelectedOption, "M"))
{
    var multiplication = firstNumber * secondNumber;
    PrintCalculatedEquation(firstNumber, secondNumber, "*", multiplication);
}
else
{
    Console.WriteLine("Invalid option!");
}

Console.WriteLine("Press any key to close.");

void PrintCalculatedEquation(int number1, int number2, string @operator, int operation)
{
    Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + operation);
}

bool CompareCaseSensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

Console.ReadKey();
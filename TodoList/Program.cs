using System.ComponentModel;

Console.WriteLine("Please provide a number: ");

string userInput = Console.ReadLine();

int number = int.Parse(userInput);

Console.WriteLine("The number is: " + number);

Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();
bool isLong = IsLong(userChoice);
Console.WriteLine(isLong);


var result = Concatenat("Heidi", 13);
Console.WriteLine("My name is " + result);

if (userChoice == "S")
{
    PrintSelectedChoice("See all TODOs");
}

else if (userChoice == "A")
{
    PrintSelectedChoice("Add a TODO");
}

else if (userChoice == "R")
{
    PrintSelectedChoice("Remove a TODO");
}

else if (userChoice == "E")
{
    PrintSelectedChoice("Exit");
}

void PrintSelectedChoice(string selectedChoice)
{
    Console.WriteLine("Selected Option: " + selectedChoice);
}

Console.WriteLine(PrintSelectedChoice("ORICE"));

bool IsLong(string input)
{
    return input.Length > 10;

}

string Concatenat(string text1, int a)
{
    return text1 + a;
}

Console.ReadKey();
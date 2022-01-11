// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("");

Console.WriteLine("Welcome to your free Savings Calculator \n");

Console.WriteLine("Please answer the follwing questions.\n");

Console.ForegroundColor = ConsoleColor.DarkRed;

Console.WriteLine("=====================================");

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine("Please enter your initial deposit \n");
var initialDeposit = 0;
int.TryParse(Console.ReadLine(), out initialDeposit);
Console.WriteLine($"You have entered {initialDeposit}\n");

Console.WriteLine("Please enter your monthly interest rate % \n");
var interestRate = 0.0;
double.TryParse(Console.ReadLine(), out interestRate);
Console.WriteLine($"You have entered {interestRate}\n");

Console.WriteLine("Please enter the number of months you will save for \n");
var numberofMonths = 0;
int.TryParse(Console.ReadLine(), out numberofMonths);
Console.WriteLine($"You have entered {numberofMonths}\n");

Console.ResetColor();

Console.WriteLine("Thank you, calculating total savings...\n");
Console.WriteLine("=====================================\n");
Console.WriteLine("");

var savings = initialDeposit * Math.Pow((1 + interestRate),numberofMonths);
Console.WriteLine($"Your total savings will be {savings}\n");

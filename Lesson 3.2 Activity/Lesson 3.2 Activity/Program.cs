// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("");

Console.WriteLine("Welcome to your free Savings Calculator \n");

Console.WriteLine("Please answer the following questions.\n");

//Setting colours
Console.ForegroundColor = ConsoleColor.DarkRed;

Console.WriteLine("=====================================");

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;

//Questions begin
Console.WriteLine("Please enter your initial deposit \n");
var initialDeposit = 0.0;
double.TryParse(Console.ReadLine(), out initialDeposit);
Console.WriteLine($"You have entered {initialDeposit}\n");

Console.WriteLine("Please enter your monthly interest rate % \n");
var interestRate = 0.0;
double.TryParse(Console.ReadLine(), out interestRate);
Console.WriteLine($"You have entered {interestRate}\n");

Console.WriteLine("Please enter the number of months you will save for \n");
var numberOfMonths = 0;
int.TryParse(Console.ReadLine(), out numberOfMonths);
Console.WriteLine($"You have entered {numberOfMonths}\n");

Console.ResetColor();

Console.WriteLine("Thank you, calculating total savings...\n");
Console.WriteLine("=====================================\n");
Console.WriteLine("");

//Setting colour
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.BackgroundColor = ConsoleColor.Cyan;

//Calculating savings amount $$$
var savings = initialDeposit * Math.Pow((1 + interestRate),numberOfMonths);
Console.WriteLine($"Your total savings will be ${Math.Round(savings, 2)}\n");

//Reset background colour
Console.BackgroundColor = ConsoleColor.Black;

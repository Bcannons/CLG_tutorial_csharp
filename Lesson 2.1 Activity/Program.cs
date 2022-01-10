// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var welcomeMessage = "Hello, today I will be asking a series of questions to which the answers will be created into a short script for you! Let's begin!";
Console.WriteLine(welcomeMessage.ToUpper());
Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var responseMessage1 = $"Hello {name}, nice to meet you, let's play on!";
Console.WriteLine(responseMessage1);
Console.WriteLine("What is your favorite animal?");
var favoriteAnimal = Console.ReadLine();
Console.WriteLine("Which country is your favorite?");
var favoriteCountry = Console.ReadLine();
Console.WriteLine("Ghosts are real, true or false?");
var trueFalseGhost = Console.ReadLine();
var responseMessage2 = "All done! Computing....";
Console.WriteLine(responseMessage2);
var responseMessage3 = $"{name} went on a quest to find the last {favoriteAnimal} of {favoriteCountry}. {name} took the {trueFalseGhost} {favoriteAnimal} to {favoriteCountry} The End!";
Console.WriteLine(responseMessage3);
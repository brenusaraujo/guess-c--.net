using System;
//main class

//entrypoint method
//start here//
string appName = "Number Guesser";
string appVersion = "1.0.0";
string appAuthor = "Breno";

//change text color

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
//reset color
Console.ResetColor();

Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

Console.WriteLine("whats your name?");

string input = Console.ReadLine();

Console.WriteLine("hello {0}", input);

Random random = new Random();

int correctNumber = random.Next(1, 10);

int guess = 0;


//ask user for a number
Console.WriteLine("guess a number between 1 to 10");

//while guess is not correct
while (guess != correctNumber)
{
    //get users input
    string userInput = Console.ReadLine();

    //make sure its a number;

    if (!int.TryParse(userInput, out guess))
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("it's not a number");
        Console.ResetColor();
    }
    //convert into the guess
    guess = Int32.Parse(userInput);
    //match guess to correct number
    if (guess != correctNumber)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("wrong number");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("right number");
        Console.ResetColor();
    }
}

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Sample:
// string input = "yes";

// while (input == "yes")
// {
//     Console.Write("Do you want to continue? ");
//     input = Console.ReadLine();
// }

//
// Generates a random number within a range.      
Random randomGenerator = new Random();
int magicNumber = randomGenerator.Next(1, 100);

int guess = -1;

// We could also use a do-while loop here...
while (guess != magicNumber)
{
    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());
    if (magicNumber > guess)
    {
        Console.WriteLine("Go higher");
    }
    else if (magicNumber < guess)
    {
        Console.WriteLine("Go lower");
    }
    else
    {
        Console.WriteLine("You guessed it!");
    }
}
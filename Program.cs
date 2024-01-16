// Generate a random secret number and establish necessary variables
Random random = new Random();
int secretNumber = random.Next(1, 101);
int guessingOpportunities = 0;
int difficultyLevel;

Console.WriteLine("Welcome to the Great Gabbo's Guessing Game of Great Guessing! It's up to you to guess the secret number!");

// ESTABLISH THE DIFFICULTY LEVEL AND SET THE NUMBER OF OPPORTUNITIES ACCORDINGLY
Console.WriteLine(@"Choose your difficulty level:
1. Easy (8 total guesses)
2. Medium (6 total guesses)
3. Hard (4 total guesses)
4. Cheater Mode (Unlimited Guesses)");

while (!int.TryParse(Console.ReadLine(), out difficultyLevel) || difficultyLevel < 1 || difficultyLevel > 5)
{
    Console.WriteLine("Invalid input. The Great Gabbo demands a number between 1 and 4.");
}

if (difficultyLevel == 1)
{
    guessingOpportunities = 8;
    RegularGameMode(secretNumber, guessingOpportunities);
}
else if (difficultyLevel == 2)
{
    guessingOpportunities = 6;
    RegularGameMode(secretNumber, guessingOpportunities);
}
else if (difficultyLevel == 3)
{
    guessingOpportunities = 4;
    RegularGameMode(secretNumber, guessingOpportunities);
}
else
{
    InfiniteGameMode(secretNumber);
}

static void RegularGameMode(int secretNumber, int guessingOpportunities)
{
    int userGuess;
    while (guessingOpportunities > 0)
    {
        Console.WriteLine($"You have {guessingOpportunities} guesses remaining.");
        // Prevents the user from entering a non-integer. 
        while (!int.TryParse(Console.ReadLine(), out userGuess))
        {
            Console.WriteLine("Invalid input. The Great Gabbo demands a number.");
        }
        // Check the user's input. If it's the right answer, break out of the loop and end the game. Otherwise, run it back.
        if (userGuess == secretNumber)
        {
            Console.WriteLine("You've done it! You've won Great Gabbo's Guessing Game of Great Guessing! Your prize is eternal glory!");
            return; // Exit the method upon winning
        }
        else
        {
            Console.WriteLine("Oh, dear me. No. That's not it at all. The Great Gabbo feels infinite shame for you.");
            guessingOpportunities -= 1;
            if (userGuess < secretNumber)
            {
                Console.WriteLine("Your guess was too low!");
            }
            else
            {
                Console.WriteLine("Your guess was too high!");
            }
        }
    }

    Console.WriteLine($"Game Over! The correct number was {secretNumber}");
}

static void InfiniteGameMode(int secretNumber)
{
    Console.WriteLine("You have selected Infinite Mode. Feel the Unlimited Power course through you!");
    int userGuess = 0;
    while (userGuess != secretNumber)
    {
        Console.WriteLine($"The Great Gabbo requests a guess.");
        // Prevents the user from entering a non-integer. 
        while (!int.TryParse(Console.ReadLine(), out userGuess))
        {
            Console.WriteLine("Invalid input. The Great Gabbo demands a number.");
        }
        // Check the user's input. If it's the right answer, break out of the loop and end the game. Otherwise, run it back.
        if (userGuess == secretNumber)
        {
            Console.WriteLine("You've done it! You've won Great Gabbo's Guessing Game of Great Guessing! Your prize is eternal glory!");
            return; // Exit the method upon winning
        }
        else
        {
            Console.WriteLine("Oh, dear me. No. That's not it at all. The Great Gabbo feels infinite shame for you.");
            if (userGuess < secretNumber)
            {
                Console.WriteLine("Your guess was too low!");
            }
            else
            {
                Console.WriteLine("Your guess was too high!");
            }
        }
    }

    Console.WriteLine($"Game Over! The correct number was {secretNumber}");
}
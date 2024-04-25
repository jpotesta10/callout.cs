using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 101); // Generates a random number between 1 and 100
            int userGuess = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (userGuess != numberToGuess)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                // Try to convert the string to a number
                if (int.TryParse(input, out userGuess))
                {
                    if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Too high! Guess again.");
                    }
                    else if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Too low! Guess again.");
                    }
                    else
                    {
                        Console.WriteLine("Correct! You guessed the number!");
                    }
                }
                else
                {
                    Console.WriteLine("That's not a number. Please enter a valid number.");
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

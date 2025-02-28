using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);

            int count = 0;

            bool running = true;
            bool runningTwo = true;

            while(running)
            {    
                Console.WriteLine("Insert number: ");
                string playerGuess = Console.ReadLine();
                count++;
                int convertGuess = int.Parse(playerGuess);
                while(runningTwo)
                {
                    if (convertGuess < 0 | convertGuess > 30)
                        Console.WriteLine("Numbers must be between 0 and 30. Try again.");
                    else if (convertGuess < numberToGuess)
                        Console.WriteLine("The hidden number is higher than " + convertGuess + ". Try again.");
                    else if (convertGuess > numberToGuess)
                        Console.WriteLine("The hidden number is lower than " + convertGuess + ". Try again.");
                    else
                        Console.WriteLine("You found the hidden number " + numberToGuess + " after " + count + " tries.");
                    break;
                }       
                break;
            }

            

        }
    }
}

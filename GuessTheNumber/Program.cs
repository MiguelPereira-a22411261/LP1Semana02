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

            while(running)
            {    
                Console.WriteLine("Insert number: ");
                string playerGuess = Console.ReadLine();
                count++;
                int convertGuess = Int32.Parse(playerGuess);
                
            }

            

        }
    }
}

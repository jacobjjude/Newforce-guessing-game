using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int intVal;
            int counter = 0;
            int secretNumber = 42;

            while (counter < 4)
            {
                Console.WriteLine("Guess the secret number: ");
                userInput = Console.ReadLine();
                intVal = Convert.ToInt32(userInput);
                Console.WriteLine($"You entered {intVal}");

                if (secretNumber == intVal)
                {
                    Console.WriteLine("You did it!");
                    counter = 4;
                }
                else
                {
                    Console.WriteLine("Try again, you big dummy!");
                    counter++;
                }
            }
        }
    }
}

using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables, store.
            string userInput;
            int intVal;
            Console.WriteLine("Guess the secret number: ");
            userInput = Console.ReadLine();
            //convert to integer
            intVal = Convert.ToInt32(userInput);
            Console.WriteLine($"You entered {intVal}");
        }
    }
}

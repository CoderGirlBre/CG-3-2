using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //This Console.WriteLine is like the title.
            Console.WriteLine("Guessing Game");

            //This allows the user to input the number.
            Console.Write("Pick a number 1-10: ");

            //This reads the number the user entered and assigns it to a variable called userValue.
            string userValue = Console.ReadLine();

            //This is an Inline If statement asking "did the user enter 8?" It is also providing two options, "win" or "lose." If the user
            //did enter 8, it will assign the first option (win) to the variable called message. If they did not enter 8, it would assign what's on the
            // other side of the colon (lose).
            string message = (userValue == "8") ? "win" : "lose";

            //The {0} will be replaced with whatever option (win or lose) corresponds to what the user entered.
            //What's in the quotes will be printed to the console and read.
            Console.WriteLine("You {0}!", message);
            Console.ReadLine();
        }
    }
}

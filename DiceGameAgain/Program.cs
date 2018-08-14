using System;

namespace DiceGameAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro to game
            Console.WriteLine("Welcome to the Dice Game, Who will get to 20 first?");
            Console.WriteLine("Let's Roll!");
            Console.WriteLine(" ");

            //Initializing variables
            int total1 = 0;
            int total2 = 0;

            //creates a loop to keep rolling until one player hits 20
            do
            {
                //Uses method to roll the dice and then returns total of those dice of player
                Console.WriteLine("Your turn");
                //Takes new total and adds to previous total 
                total1 = Roll(total1) + total1;
                //Outputs the running total or score
                Console.WriteLine("Your total is " + total1);
                Console.WriteLine(" ");

                //breaks from loop if player gets to or past 20
                if (total1 >= 20)
                {
                    Console.WriteLine("YOU ARE THE WINNER!");
                    break;
                }

                //Uses method to roll dice and get a total for the two dice on computers turn
                //then adds the new total to previous total for the computer
                Console.WriteLine("Computer's turn");
                total2 = Roll(total2) + total2;
                //Outputs running total
                Console.WriteLine("Computer total is " + total2);
                Console.WriteLine(" ");

                //breaks out of loop if computer total gets to 20 or above
                if (total2 >= 20)
                {
                    Console.WriteLine("COMPUTER WINS!");
                    break;
                }

                //Pauses program at each new roll will continue when enter is pressed
                Console.WriteLine("Press Enter to Roll again.");
                Console.ReadLine();

            }

            //continues to do loop if neither totals has reached 20
            while (total1 <= 20 || total2 <= 20);
            Console.ReadLine();

        }

        /// <summary>
        /// This method rolls 2 dice and returns the total of those dice
        /// </summary>
        /// <param name="total">sum of the values of the two dice rolled</param>
        /// <returns>sum of the dice</returns>        
        private static int Roll(int total)
        {
            Random myRandom = new Random();
            int dice1 = myRandom.Next(1, 7);
            int dice2 = myRandom.Next(1, 7);
            Console.WriteLine($"Dice 1 is: {dice1}         Dice 2 is: {dice2}");
            
            return dice1 + dice2;

        }
    }
}

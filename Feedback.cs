using System;
using System.Collections.Generic;
using System.Text;

namespace Dice_Game
{
    class Feedback
    {
        public void Log(string msg) { Console.WriteLine(msg); }
        public void Win() { Console.WriteLine("You win!"); }
        public void Lose() { Console.WriteLine("You lose!"); }
        public void Rules() 
        { 
            Console.WriteLine(
            "     CRAPS:\n" +
            "---- RULES ----\n" +
            "A gambling game played with two dice, chiefly in North America.\n" +
            "You roll two dice.After the dice have come to rest, the sum of the spots on the two upward faces is calculated.\n" +
            "If the sum is 7 or 11 on the first throw, you win.\n" +
            "If the sum is 2, 3 or 12 on the first throw (called “craps”), you lose(i.e., “the house” wins). \n" +
            "If the sum is 4, 5, 6, 8, 9 or 10 on the first throw, that sum becomes your “point.” \n" +
            "To win, you must continue rolling the dice until you “make your point” (i.e., roll that same point value). \n" +
            "You lose by rolling a 7 before making your point.\n" +
            "---- ~RULES ----\n"); 

        }
    }
}

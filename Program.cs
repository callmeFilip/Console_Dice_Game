using System;

/*
 CRAPS:
     A gambling game played with two dice, chiefly in North America.
     You roll two dice. After the dice have come to rest, the sum of the spots on the two upward faces is calculated.
     If the sum is 7 or 11 on the first throw, you win.
     If the sum is 2, 3 or 12 on the first throw (called “craps”), you lose (i.e., “the house” wins). 
     If the sum is 4, 5, 6, 8, 9 or 10 on the first throw, that sum becomes your “point.” 
     To win, you must continue rolling the dice until you “make your point” (i.e., roll that same point value). 
     You lose by rolling a 7 before making your point.
*/

namespace Dice_Game
{
    enum DiceOutcome
    {
        LOSE,
        WIN,
        POINT,
        LENGTH
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int GAMESCOUNT = 20;

            Feedback report = new Feedback();
            Game game = new Game(ref report);

            Dice dice = new Dice();
            House house = new House(ref dice);

            report.Rules(); // prints the rules

            for (int i = 1; i <= GAMESCOUNT; i++)
            {
                report.Log($"---- Game #{i} ----");
                game.play(house);
            }
        }
    }
}

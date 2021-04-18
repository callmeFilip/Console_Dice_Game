using System;
using System.Collections.Generic;
using System.Text;

namespace Dice_Game
{
    class House
    {
        private Dice m_dice;
        private bool m_isPointScored;

        public House(ref Dice dice) { m_dice = dice; m_isPointScored = false; }

        public int PlayRound()
        {
            return m_dice.Roll(); // This returns the sum of 2 dices
        }

        public DiceOutcome CheckResult(ref int roundResult) 
        {
            DiceOutcome result = DiceOutcome.LENGTH;

            switch (roundResult) 
            {
                // Point conditions
                case 4:
                case 5:
                case 6:
                case 8:
                case 9:
                case 10:
                    result = DiceOutcome.POINT;
                    m_isPointScored = true;
                    break;

                // Losing conditions
                case 2:
                case 3:
                case 12:
                    result =  DiceOutcome.LOSE;
                    m_isPointScored = false;
                    break;

                // Wining conditions
                case 7:
                    if (!m_isPointScored) // if you roll 7 whitout scoring a point first
                    { 
                        result = DiceOutcome.LOSE; 
                    } 
                    else 
                    {
                        result = DiceOutcome.WIN;
                    } 
                    m_isPointScored = false;
                    break;
                case 11:
                    result = DiceOutcome.WIN;
                    m_isPointScored = false;
                    break;

                default:
                    Console.WriteLine("Enumeration out of bound House.cs ; ROW: 44 ");
                    break;
            } // ~switch (roundResult)

            return result;
        }

    }
}

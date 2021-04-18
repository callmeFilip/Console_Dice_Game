using System;
using System.Collections.Generic;
using System.Text;

namespace Dice_Game
{
    class Game
    {
        private Feedback m_report;

        public Game(ref Feedback report) { m_report = report; }

        public void play(House house) 
        {
            int roundResult;
            DiceOutcome outcome = DiceOutcome.LENGTH;
            do
            {
                roundResult = house.PlayRound();

                m_report.Log("Player rolled: " + roundResult);

                outcome = house.CheckResult(ref roundResult);

                if (outcome == DiceOutcome.LOSE) { m_report.Lose(); break; }
                else if (outcome == DiceOutcome.WIN) { m_report.Win(); break; }

            } while (true);
        }
    }
}

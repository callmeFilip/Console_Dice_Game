using System;
using System.Collections.Generic;
using System.Text;

namespace Dice_Game
{
    class Dice
    {
        private Random m_random;
        public Dice() 
        {
            m_random = new Random();
        }
        public int Roll() 
        {
            return m_random.Next(2, 13);
        }
    }
}

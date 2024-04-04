using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A124
{
    internal class Dice
    {
        private int sideCount;
        Random rnd = new Random();
        public Dice()
        {
            sideCount = 6;
        }
        public Dice(int sideCount)
        {
            this.sideCount = sideCount;
        }
        public int GetSideCount()
        {
            return sideCount;
        }
        public int Roll()
        {
            return rnd.Next(1, sideCount + 1);
        }
    }
}

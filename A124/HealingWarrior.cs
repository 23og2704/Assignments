using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A124
{
    public class HealingWarrior : Warrior
    {
        private bool haveHealed;
        public HealingWarrior(string name) : base(name)
        {
            maxHealth = 75;
            currentHealth = maxHealth;
            attackDamage = 5;
            haveHealed = false;
        }
        public bool getHaveHealed()
        {
            if (!haveHealed)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void heal()
        {
            if (haveHealed)
            {
                System.Console.WriteLine("You have healed already");
            }
            else
            {
                currentHealth = maxHealth;
                haveHealed = true;
            }
        }
    }
}

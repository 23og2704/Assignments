using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A124
{
    public class MageWarrior : Warrior
    {
        private int mana;
        private int maxMana;
        private int magicDamage;
        public MageWarrior(string name, int maxManaInput, int magicDamageInput) : base(name)
        {
            maxMana = maxManaInput;
            mana = maxMana;
            magicDamage = magicDamageInput;
        }
        public int getMana()
        {
            return mana;
        }
        public override void Attack(Warrior enemy, int diceRoll)
        {
            if (mana < maxMana)
            {
                if (mana + 10 <= maxMana)
                {
                    mana += 10;
                }
                else
                {
                    mana = maxMana;
                }
                base.Attack(enemy, diceRoll);
            } 
            else
            {
                enemy.Attacked(diceRoll, magicDamage);
                mana = 0;
            }
        }
    }
}

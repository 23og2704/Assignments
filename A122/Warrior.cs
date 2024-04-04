namespace A122
{
    internal class Warrior
    {
        private string name;
        private int currentHealth;
        private int maxHealth;
        private int attackDamage;
        public Warrior(string myName) 
        {
            name = myName;
            maxHealth = 100;
            currentHealth = maxHealth;
            attackDamage = 10;
        }
        public int GetHealth() => currentHealth;
        public string GetName() => name;
        public bool IsAlive() => currentHealth > 0;
        public void Attack(Warrior enemy, int diceRoll)
        {
            enemy.Attacked(diceRoll, attackDamage);
        }
        public void Attacked(int diceRoll, int attackedDamage)
        {
            currentHealth -= diceRoll * attackedDamage;
        }
    }
}

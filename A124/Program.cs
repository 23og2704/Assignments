using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A124
{
    internal class Program
    {
        static void healthBar(int health)
        {
            string healthSymbol = "\u2588";
            if (health > 0)
            {
                Console.Write("[");
                for (int i = 0; i < health / 2; i++)
                {
                    Console.Write(healthSymbol);
                }
                Console.Write("]\n");
            }
            else
            {
                Console.WriteLine("DEAD");
            }

        }
        static void Health(HealingWarrior hero, MageWarrior enemy)
        {
            Console.WriteLine($"Heroes Health: {hero.GetHealth()}");
            healthBar(hero.GetHealth());
            Console.WriteLine($"Enemy's Health: {enemy.GetHealth()}");
            healthBar(enemy.GetHealth());
            Console.WriteLine($"Enemy's Mana: {enemy.getMana()}\n");
        }
        static void Fight(HealingWarrior hero, MageWarrior enemy, Dice myDice)
        {
            Console.WriteLine("FIGHT!!\n");
            do
            {
                enemy.Attack(hero, myDice.Roll());
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{enemy.GetName()} attacked {hero.GetName()}!");
                Console.ResetColor();
                Health(hero, enemy);
                if (hero.IsAlive() && enemy.IsAlive())
                {
                    if (hero.getHaveHealed() == false)
                    {
                        Console.WriteLine("Would you like to heal? (Y / N)");
                        char choice = char.Parse(Console.ReadLine());
                        if (choice == 'Y')
                        {
                            hero.heal();
                            Console.WriteLine($"Hero healed to full HP!");
                        }
                        else { }
                    }
                    else { }
                    hero.Attack(enemy, myDice.Roll());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{hero.GetName()} attacked {enemy.GetName()}!");
                    Console.ResetColor();
                    Health(hero, enemy);
                }

            } while (hero.IsAlive() && enemy.IsAlive());
            if (hero.IsAlive())
            {
                Console.WriteLine($"\n{hero.GetName()} won!");
            }
            else if (enemy.IsAlive())
            {
                Console.WriteLine($"\n{enemy.GetName()} won!");
            }
            else
            {
                Console.WriteLine("\nTie?!");
            }
        }
        static void Start()
        {
            Console.WriteLine("How many sides should the dice have: ");
            Dice myDice = new Dice(int.Parse(Console.ReadLine()));
            HealingWarrior hero = new HealingWarrior("Healer Oscar");
            MageWarrior enemy = new MageWarrior("Mage Matt", 100, 20);

            Console.WriteLine($"\nHero: {hero.GetName()}");
            Console.WriteLine($"Health: {hero.GetHealth()}\n");
            Console.WriteLine($"Enemy: {enemy.GetName()}");
            Console.WriteLine($"Health: {enemy.GetHealth()}");
            Console.WriteLine($"Mana: {enemy.getMana()}\n");
            Fight(hero, enemy, myDice);

        }
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }
    }
}


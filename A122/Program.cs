using System;
namespace A122
{
    internal class Program
    {
        static void Health(Warrior hero, Warrior enemy)
        {
            Console.WriteLine($"Heroes Health: {hero.GetHealth()}");
            Console.WriteLine($"Enemy's Health: {enemy.GetHealth()}");
        }
        static void Fight(Warrior hero, Warrior enemy, Dice myDice)
        {
            Console.WriteLine("FIGHT!!\n");
            do
            {
                enemy.Attack(hero, myDice.Roll());
                Console.WriteLine($"{enemy.GetName()} attacked {hero.GetName()}!");
                Health(hero, enemy);
                if (hero.IsAlive() && enemy.IsAlive())
                {
                    hero.Attack(enemy, myDice.Roll());
                    Console.WriteLine($"{hero.GetName()} attacked {enemy.GetName()}!");
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
            Warrior hero = new Warrior("Oscar");
            Warrior enemy = new Warrior("Matt");

            Console.WriteLine($"\nHero: {hero.GetName()}");
            Console.WriteLine($"Health: {hero.GetHealth()}\n");
            Console.WriteLine($"Enemy: {enemy.GetName()}");
            Console.WriteLine($"Health: {enemy.GetHealth()}\n");
            Fight(hero, enemy, myDice);

        }
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
            //Part 1 code:

            //Dice sixsideddie = new Dice();
            //Dice tensideddie = new Dice(10);
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Six sided die, throw {i + 1} : {sixsideddie.Roll()}");
            //}
            //Console.WriteLine("");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Ten sided die, throw {i + 1} : {tensideddie.Roll()}");
            //}
            //Console.ReadKey();
        }
    }
}

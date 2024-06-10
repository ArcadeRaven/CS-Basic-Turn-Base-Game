using System;

namespace TurnBased
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;

            int playerAtk = 5;
            int enemyAtk = 7;

            int healAmount = 5;

            Random random = new Random();

            while (playerHp > 0 && enemyHp > 0)
            {
                // player turn
                System.Console.WriteLine("-- Player Turn --");
                System.Console.WriteLine("Player HP = " + playerHp + ". Enemy HP = " + enemyHp);
                System.Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= playerAtk;
                    System.Console.WriteLine("Player attack enemy and deals " + playerAtk + " damage!");

                }
                else
                {
                    playerHp += healAmount;
                    System.Console.WriteLine("Player restores " healAmount + " hp!");
                }

                // enemy turn
                System.Console.WriteLine("Player HP = " + playerHp + ". Enemy HP = " + enemyHp);
                if (enemyHp > 0)
                {
                    System.Console.WriteLine("-- Enemy Turn --");
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAtk;
                        System.Console.WriteLine("Enemy attacks and deals " + enemyAtk + " damage!");
                    }
                    else
                    {
                        enemyHp += healAmount;
                        System.Console.WriteLine("Enemy restores " + healAmount + " hp!");
                    }
                }
            }

            // check win
            if (playerHp > 0)
            {
                System.Console.WriteLine("Congratulations, you won!");
            }
            else
            {
                System.Console.WriteLine("You lose.");
            }
        }
    }
}
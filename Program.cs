// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace TurnBased
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 40, enemyHP = 20;
            int playerAttack = 5, enemyattack = 7;
            int healamount = 5;
            Random random = new Random();

            while (playerHP>0 && enemyHP > 0)
            {
                //Player turn
                Console.WriteLine("--Player Turn--");
                Console.WriteLine("Player HP is " + playerHP + " Enemy HP is " + enemyHP);
                Console.WriteLine("Enter 'a' to attack and 'h' to heal ");
                string choice = Console.ReadLine();

                if (choice == "a")  
                {
                    enemyHP -= playerAttack;
                    Console.WriteLine("Player attack enemy " + playerAttack + " damage!");
                }
                else
                {
                    playerHP += healamount;
                    Console.WriteLine("Player estore " + healamount + " heal points");
                }

                //Enemy Turn

                if (enemyHP > 0)
                {
                    Console.WriteLine("--Enemy turn--");
                    Console.WriteLine("Player HP is " + playerHP + " Enemy HP is " + enemyHP);
                    int enemychoice = random.Next(0, 2);

                    if (enemychoice == 0)
                    {
                        playerHP -= enemyattack;
                        Console.WriteLine("Enemy attack and deal " + enemyattack + " damage ! ");
                    }
                    else
                    {
                        enemyHP += healamount;Console.WriteLine("Enemy restore " + healamount + " health point ");


                    }



                }
                






            }

            if (playerHP > 0)
            {
                Console.WriteLine("Congratulation you have won");
            }
            else
            {
                Console.WriteLine("you loss");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Conditionals___Nathan_Peach
{
    internal class Program
    {
        //Variable declaration
        static int health;
        static string weapon;
        static string armor;
        static void Main(string[] args)
        {
            //Variable initialization
            health = 3;
            
            Console.WriteLine(" - CONDITIONALS ASSIGNMENT - ");
            
            ShowHud();
            GetWeapon(0);
            ShowHud();
            GetArmor(0);
            ShowHud();
            TakeDamage(1);
            ShowHud();
            TakeDamage(2);
            ShowHud();
            //new event
            ShowHud();
            //new event
        }
        static void ShowHud()
        {
            //Displays a different number of hearts based on user health
            Console.WriteLine("");
            Console.WriteLine("[]----------[]");
            if (health == 3)
            {
                Console.WriteLine("|| <3 <3 <3 ||");
            }
            if (health == 2)
            {
                Console.WriteLine("|| <3 <3    ||");
            }
            if (health == 1)
            {
                Console.WriteLine("|| <3       ||");
            }
            Console.WriteLine("[]----------[]");
            Console.WriteLine("Equipment: "+weapon+" & "+armor);
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue --->");
            Console.WriteLine("");
            Console.ReadKey(false);
        }
        static void GetWeapon(int weaponid)
        {
            if (weaponid == 0)
            {
                weapon = "Sword";
                Console.WriteLine("You found a " + weapon);
            }
        }
        static void GetArmor(int armorid)
        {
            if (armorid == 0)
            {
                armor = "Chainmail";
                Console.WriteLine("You found a set of " + armor);
            }
        }
        static void TakeDamage(int damage)
        {
            if (damage == 1)
                Console.WriteLine("Player is about to lose a heart.");
            if (damage >= 2)
                Console.WriteLine("Player is about to lose " + damage + " hearts.");

            if (armor == "Chainmail")
            {
                damage = damage - 1;
                Console.WriteLine("The damage was reduced by your " + armor + "!");
            }

            //Takes away health by the damage value
            health = health - damage;
            
            //sets health to 0 if health is less than or equal to 0
            if (health <= 0)
            {
                health = 0;
                Console.WriteLine("Player has died...");
                Console.WriteLine("");
                Console.WriteLine("Press any key to exit game --->");
                Console.ReadKey(false);
                Environment.Exit(0);
            }
        }
    }
}

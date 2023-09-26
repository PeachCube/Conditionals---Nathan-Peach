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
        static int weaponid = 0;
        static int armorid = 0;
        static string HS;
        static void Main(string[] args)
        {
            //Variable initialization
            health = 3;

            Console.WriteLine(" - CONDITIONALS ASSIGNMENT - ");

            ShowHud();
            GetWeapon(1);
            ShowHud();
            GetArmor(1);
            ShowHud();
            TakeDamage(1);
            ShowHud();
            TakeDamage(2);
            ShowHud();
            Heal(1);
            ShowHud();
            //new event
        }
        static void Heal(int healing)
        {
            health = health + healing;
            Console.WriteLine("- Player healed for "+healing+" HP.");
        }
        static void GetWeapon(int weaponid)
        {
            if (weaponid == 1)
            {
                weapon = "Broadsword";
                Console.WriteLine("- You found a " + weapon);
            }
        }
        static void GetArmor(int armorid)
        {
            if (armorid == 1)
            {
                armor = "Chainmail";
                Console.WriteLine("- You found a set of " + armor);
            }
        }
        static void TakeDamage(int damage)
        {
            if (damage == 1)
                Console.WriteLine("- Player is about to lose a heart.");
            if (damage >= 2)
                Console.WriteLine("- Player is about to lose " + damage + " hearts.");

            if (armor == "Chainmail")
            {
                damage = damage - 1;
                Console.WriteLine("- Your " + armor + " reduced the damage by 1 heart!");
            }

            //Takes away health by the damage value
            health = health - damage;

            //sets health to 0 if health is less than or equal to 0
            if (health <= 0)
            {
                health = 0;
                Console.WriteLine("-  Player has died...");
                Console.WriteLine("");
                Console.WriteLine("Press any key to exit game --->");
                Console.ReadKey(false);
                Environment.Exit(0);
            }
        }
        static void ShowHud()
        {
            //Displays a different number of hearts based on user health
            Console.WriteLine("");  
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
            Console.WriteLine("");
            Console.WriteLine("Weapon: " + weapon);
            Console.WriteLine("Armor: " + armor);
            if (health == 3)
            {
                HS = "Very Healthy";
                Console.WriteLine("Health Status: " + HS); 
            }
            if (health == 2)
            {
                HS = "Slightly Damaged";
                Console.WriteLine("Health Status: " + HS);
            }
            if (health == 1)
            {
                HS = "Greatly Wounded";
                Console.WriteLine("Health Status: " + HS);
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue --->");
            Console.WriteLine("");
            Console.WriteLine("V V V EVENT LOG V V V");
            Console.WriteLine("");
            Console.ReadKey(false);
        }
    }
}

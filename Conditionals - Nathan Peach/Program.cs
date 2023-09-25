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
        static void Main(string[] args)
        {
            //Variable initialization
            health = 100;

            Console.WriteLine("-Conditionals Assignment-");
            
            ShowHud();
            TakeDamage(25);
            ShowHud();
            TakeDamage(50);
            ShowHud();
            TakeDamage(25);
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
        static void TakeDamage(int damage)
        {
            health = health - damage;
        }
        static void ShowHud()
        {
            Console.WriteLine("Health: " + health);
        }
    }
}

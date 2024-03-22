using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerUp pwrup = PowerUp.shield;
            int e = int.Parse(args[0]);
            Enemy[] array = new Enemy [e];
            for (int i = 0; i<=(e-1); i++)
            {
                Console.Write($"Nome do inimigo {i+1}: ");
                string n = Console.ReadLine();
                array[i] = new Enemy(n);
            }
            array[0].PickupPowerUp(pwrup,50);
            array[0].TakeDamage(70);
            for (int i = 0; i<=(e-1); i++)
            {
                Console.Write($"{array[i].GetName()} {array[i].GetHealth()} ");
                Console.Write($"{array[i].GetShield()} ");
            }
            Console.WriteLine($"{Enemy.GetPowerUps()}");
        }
    }
}

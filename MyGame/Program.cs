using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = int.Parse(args[0]);
            Enemy[] array = new Enemy [e];
            for (int i = 0; i<=(e-1); i++)
            {
                Console.Write($"Nome do inimigo {i+1}: ");
                string n = Console.ReadLine();
                array[i] = new Enemy(n);
            }
            for (int i = 0; i<=(e-1); i++)
            {
                Console.WriteLine
                ($"{array[i].GetName()} {array[i].GetHealth()} {array[i].GetShield()}");
            }
        }
    }
}

using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declara e instancia dois cronómetros, crono1 e crono2
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            //Inicia contagem do tempo em crono1
            crono1.Start();
            //Pausa o programa durante 0.6 segundos (600 milissegundos)
            Thread.Sleep(600);
            //Inicia contagem do tempo em crono2
            crono2.Start();
            //Pausa o programa durante mais 0.2 segundos
            Thread.Sleep(200);
            //Pára contagem do tempo nos dois cronómetros
            crono1.Stop();
            crono2.Stop();

            long crono1t = crono1.ElapsedMilliseconds;
            long crono2t = crono2.ElapsedMilliseconds;

            double crono1s = crono1t / 1000.0;
            double crono2s = crono2t / 1000.0;

            Console.WriteLine(crono1s);
            Console.WriteLine(crono2s);
        }
    }
}
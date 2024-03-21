using System;

namespace RanDice
{
    class Program
    {   
        
        static void Main(string[] args)
        {

            int n = int.Parse(args[0]); 
            int s = int.Parse(args[1]); 

            int sum = 0; 

            Random rand = new Random(s);

            for (int i = 0; i < n; i++)
            {
                
                int dVal = rand.Next(1,7);
                sum += dVal;
                
            }  
            Console.WriteLine(sum);     
            
        }
    }
}
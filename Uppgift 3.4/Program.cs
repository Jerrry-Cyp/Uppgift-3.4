using System;

namespace Uppgift_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange låt tid: (Minuter)");
            int Min = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange låt tid: (Sekunder)");
            int Sek = int.Parse(Console.ReadLine());

            if (Min >= 2 && Min <= 4)
            {
                if (Min >= 2 && Sek >= 45)
                {
                    Console.WriteLine("Du får spela din låt på radion");
                }
                if (Min <= 4 && Sek <= 20)
                {
                    Console.WriteLine("Du får spela din låt på radion");
                }
            }
            else Console.WriteLine("Du får inte spela din låt på radiostationen");
        }
    }
}
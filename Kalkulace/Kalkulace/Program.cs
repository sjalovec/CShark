using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulace
{
    class Program
    {
        static void Main(string[] args)
        {
            //sběr dat z obrazovky
            Console.WriteLine("Vítejte v kalkulačce");
            Console.WriteLine("Zadejte první číslo: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Napište druhé číslo: ");
            float b = float.Parse(Console.ReadLine());

            //výpočty
            float soucet = a + b;
            float rozdil = a - b;
            float soucin = a * b;
            float podil = a / b;

            //vypíše výpočty na obrazovku
            Console.WriteLine("Součet je: " + soucet);
            Console.WriteLine("Rozdíl je: " + rozdil);
            Console.WriteLine("Součin je: " + soucin);
            Console.WriteLine("Podil je: " + podil);

            Console.WriteLine("Děkuji za použití týhle výborný kalkulačky");

            Console.ReadKey();
        }
    }
}

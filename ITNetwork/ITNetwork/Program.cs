using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITNetwork
{
    class Papousek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, jsem virutální papoušek Lóra, rád opakuji!");
            Console.WriteLine("Napiš něco: ");

            /* puvodní
            string vstup;
            vstup = Console.ReadLine();
            */

            /* nová deklarace*/
            string vstup = Console.ReadLine();

            string vystup;
            vystup = vstup + " " + vstup;// + "!";

            Console.WriteLine(vystup);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umschulung_Aufgaben
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Mitarbeiter ma1 = new Mitarbeiter("Meier", 1500m, Mitarbeiter.Abteilung.Buchhaltung);
            Mitarbeiter ma2 = new Mitarbeiter("Schulze", 1500m, Mitarbeiter.Abteilung.Produktion);
            Mitarbeiter ma3 = new Mitarbeiter("Meier", 1500m, Mitarbeiter.Abteilung.Buchhaltung);


            Console.WriteLine("ma1: " + ma1);
            Console.WriteLine("ma2: " + ma2);
            Console.WriteLine("ma3: " + ma3);

            Console.WriteLine();
            Console.WriteLine("------------------------Vergleich von ma1 und ma2--------------------- ");
            Console.WriteLine();

            bool gleich = ma1.Equals(ma3);
            Console.WriteLine(gleich);
            Console.ReadLine();
        }
    }
}

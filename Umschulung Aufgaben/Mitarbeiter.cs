using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umschulung_Aufgaben
{
    internal class Mitarbeiter
    {
        private string Name  { get; }
        private decimal Gehalt { get; }
        private Abteilung Arbeit;
        public enum Abteilung { Buchhaltung, Produktion }


        public Mitarbeiter(string _name, decimal _gehalt, Abteilung _abteilung)
        {
            Name = _name;
            Gehalt = _gehalt;
            Arbeit = _abteilung;
        }   

        public Mitarbeiter(string _name, Abteilung _abteilung)
        {
            Name = _name;
            Arbeit = _abteilung;
            Gehalt = 1500m;
        }

        public override string ToString()
        {
            return "Name: " + Name + "| Abteilung: " + Arbeit + "| Gehalt: " + Gehalt; 
        }

        public override bool Equals(object obj)
        {
            if (obj is Mitarbeiter)
            {
            Mitarbeiter Cast = obj as Mitarbeiter;
            return this.Name == Cast.Name && this.Arbeit == Cast.Arbeit && this.Gehalt == Cast.Gehalt;
            }
            return false;
        }
    }
}

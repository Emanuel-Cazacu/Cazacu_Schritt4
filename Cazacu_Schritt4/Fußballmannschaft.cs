using System;
using System.Collections.Generic;
using System.Text;

namespace Cazacu_Schritt4
{
    public class Fußballmannschaft
    {
        public string Name { get; set; }
        public int Gruendungsjahr { get; set; }
        public string Vereinsfarben { get; set; }
        public string Ort { get; set; }
        public List<Spieler> spieler { get; set; }

        public Fußballmannschaft(string name, int gruendungsjahr, string vereinsfarben, string ort, List<Spieler> spieler)
        {
            Name = name;
            Gruendungsjahr = gruendungsjahr;
            Vereinsfarben = vereinsfarben;
            Ort = ort;
            this.spieler = spieler;
        }
    }
}

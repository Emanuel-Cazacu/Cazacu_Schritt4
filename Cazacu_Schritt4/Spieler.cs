using System;
using System.Collections.Generic;
using System.Text;

namespace Cazacu_Schritt4
{
    public class Spieler
    {
        public int Sozialversicherungsnummer { get; set; }
        public string Name { get; set; }
        public int Trikotnummer { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public DateTime Vertrag_bis { get; set; }

        public List<Trophaeen> trophaeenS  { get; set; }

        public Spieler(int sozialversicherungsnummer, string name, int trikotnummer, DateTime geburtsdatum, DateTime vertrag_bis, List<Trophaeen> trophaeenS)
        {
            Sozialversicherungsnummer = sozialversicherungsnummer;
            Name = name;
            Trikotnummer = trikotnummer;
            Geburtsdatum = geburtsdatum;
            Vertrag_bis = vertrag_bis;
            this.trophaeenS = trophaeenS;
        }
    }
}

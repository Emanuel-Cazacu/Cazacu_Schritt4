using System;
using System.Collections.Generic;
using System.Text;

namespace Cazacu_Schritt4
{
    public class Trainer
    {
        public int Trainerlizenz { get; set; }
        public string Name { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public int Anzahl_trophaeen { get; set; }
        public DateTime Vertrag_bis { get; set; }
        public List<Trophaeen> trophaeenT { get; set; }

        public Trainer(int trainerlizenz, string name, DateTime geburtsdatum, int anzahl_trophaeen, DateTime vertrag_bis, List<Trophaeen> trophaeenT)
        {
            Trainerlizenz = trainerlizenz;
            Name = name;
            Geburtsdatum = geburtsdatum;
            Anzahl_trophaeen = anzahl_trophaeen;
            Vertrag_bis = vertrag_bis;
            this.trophaeenT = trophaeenT;
        }
    }
}

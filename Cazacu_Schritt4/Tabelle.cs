using System;
using System.Collections.Generic;
using System.Text;

namespace Cazacu_Schritt4
{
    public class Tabelle
    {
        public DateTime Datum { get; set; }
        public int Ergebnism1 { get; set; }
        public int Ergebnism2 { get; set; }
        public string m1 { get; set; }
        public string m2 { get; set; }

        public Tabelle(DateTime datum, int ergebnism1, int ergebnism2, string m1, string m2)
        {
            Datum = datum;
            Ergebnism1 = ergebnism1;
            Ergebnism2 = ergebnism2;
            this.m1 = m1;
            this.m2 = m2;
        }
    }
}

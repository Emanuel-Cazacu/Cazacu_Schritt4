using System;
using System.Collections.Generic;
using System.Text;

namespace Cazacu_Schritt4
{
    public class Stadion
    {
        public string NameStadion { get; set; }
        public string Ort { get; set; }
        public int Gründungsjahr { get; set; }
        public List<Fußballmannschaft> Mannschaften { get; set; }

        public Stadion(string nameStadion, string ort, int gründungsjahr, List<Fußballmannschaft> mannschaften)
        {
            NameStadion = nameStadion;
            Ort = ort;
            Gründungsjahr = gründungsjahr;
            Mannschaften = mannschaften;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Cazacu_Schritt4
{
    public class Trophaeen
    {
        public int Seriennummer { get; set; }
        public string Name { get; set; }
        public DateTime Gewinnjahr { get; set; }

        public Trophaeen(int seriennummer, string name, DateTime gewinnjahr)
        {
            Seriennummer = seriennummer;
            Name = name;
            Gewinnjahr = gewinnjahr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace projekt_evidence
{
    internal class Zaznam
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public int TelCislo { get; set; }

        public Zaznam(string jmeno, string prijmeni, int vek, int telCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelCislo = telCislo;
        }

        public override string ToString()
        {
            return Jmeno + "\t" + Prijmeni + "\t" + Vek + "\t" + TelCislo;
        }
    }
}

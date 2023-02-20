using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_evidence
{
    internal class Databaze
    {
        private List<Zaznam> zaznamy;
        
        public Databaze()
        {
            zaznamy = new List<Zaznam>();
        }

        public void PridejZaznam(string jmeno, string prijmeni, int vek, int telCislo)
        {
            zaznamy.Add(new Zaznam(jmeno, prijmeni, vek, telCislo));
        }

        public Zaznam NajdiPojisteneho(string dleJmena, string dlePrijmeni)
        {
            
            foreach (Zaznam p in zaznamy)
            {
                if ((p.Jmeno == dleJmena) && (p.Prijmeni == dlePrijmeni)) //dle jmena a prijmeni
                {
                    return p;
                }
            }
            return null;
        }

        public List<Zaznam> ZkopirovaniDatabazeProVypis()
        {
            List<Zaznam> seznamPojistenych = new List<Zaznam>();
            seznamPojistenych.AddRange(zaznamy);
            return seznamPojistenych;
        }

    }
}

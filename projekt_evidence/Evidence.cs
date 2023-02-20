using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace projekt_evidence
{
    internal class Evidence
    {
        private Databaze databaze;


        public Evidence()
        {
            databaze = new Databaze();
        }


        public void VypisPojistene()
        {
            List<Zaznam> seznam = databaze.ZkopirovaniDatabazeProVypis();
            Console.WriteLine("V evidenci jsou tito pojištěnci: ");
            foreach (Zaznam p in seznam)
                Console.WriteLine(p);
        }

        public void PridejPojistence()
        {
            Console.WriteLine("Zadejte jméno:");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Zadej jmeno znovu:");
            }

            Console.WriteLine("Zadejte příjmení:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadej příjmení znovu:");
            }

            Console.WriteLine("Zadejte věk:");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.WriteLine("Chybně zadáno, zadejte znovu:");
            }

            Console.WriteLine("Zadejte telefonní číslo:");
            int telCislo;
            while (!int.TryParse(Console.ReadLine(), out telCislo) && telCislo > 999999999 || telCislo < 99999999)
            {
                Console.WriteLine("Chybně zadáno, zadejte znovu:");
            }
            databaze.PridejZaznam(jmeno, prijmeni, vek, telCislo);
        }

        public void VyhledejPojistence()
        {
            //Zadání od uživatele
            Console.WriteLine("Zadejte jméno pojištěnce:");
            string dleJmena;
            while (string.IsNullOrWhiteSpace(dleJmena = Console.ReadLine()))
            {
                Console.WriteLine("Zadej jmeno znovu:");
            }

            Console.WriteLine("Zadejte příjmení pojištěnce:");
            string dlePrijmeni;
            while (string.IsNullOrWhiteSpace(dlePrijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadej jmeno znovu:");
            }

            //vyhledání záznamu
            Zaznam zaznam = databaze.NajdiPojisteneho(dleJmena, dlePrijmeni);
            if (zaznam != null)
                Console.WriteLine(zaznam);
            else
                Console.WriteLine("Záznam neexistuje.");

        }

        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Vyberte si akci: ");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");
        }
    }
}

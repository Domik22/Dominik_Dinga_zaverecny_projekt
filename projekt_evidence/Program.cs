using projekt_evidence;

Evidence evidence = new Evidence();
char volba = '0';
while (volba != '4')
{
    evidence.VypisUvodniObrazovku();
    
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch(volba)
    {
        case '1':
            evidence.PridejPojistence();
            break;
        case '2':
            evidence.VypisPojistene();
            break;
        case '3':
            evidence.VyhledejPojistence();
            break;
        case '4':
            Console.WriteLine("Libovolnou klávesou ukončete program...");
            break;
        default:
            Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
            break;
    }
    Console.ReadKey();
}

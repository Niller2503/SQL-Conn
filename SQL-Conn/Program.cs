using BusinessLogic;
using Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        VareBL bl = new VareBL();

        bool hentAlleVareSlut = false;
        while (!hentAlleVareSlut)
        {
            Console.WriteLine("Vil du hente alle varer? (Ja/Nej)");
            string hentAlleVareSvar = Console.ReadLine().ToLower();

            while (hentAlleVareSvar != "ja" && hentAlleVareSvar != "nej")
            {
                Console.WriteLine("Forkert input, prøv igen");
                Console.WriteLine("Vil du hente alle varer? (Ja/Nej)");
                hentAlleVareSvar = Console.ReadLine().ToLower();
            }

            if (hentAlleVareSvar == "nej")
            {
                hentAlleVareSlut = true;
            }
            else
            {
                // Hent og vis varer
                var varer = bl.Get(); // Brug Get-metoden i stedet for HentAlleVarer
                foreach (var vare in varer)
                {
                    Console.WriteLine($"ID: {vare.ID}, Navn: {vare.Varenavn}, Pris: {vare.Indkøbspris}");
                }

                // Eventuel yderligere behandling af de hentede varer
            }
        }
    }
}

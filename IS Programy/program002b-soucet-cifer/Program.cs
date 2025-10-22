using System;

class Program
{
    static void Main()
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("************************************************");
            Console.WriteLine("*********** Součet a součin cifer  *************");
            Console.WriteLine("************************************************");
            Console.WriteLine("************* Matěj Horák **********************");
            Console.WriteLine("************** 22.10.2025 ***********************");
            Console.WriteLine("************************************************");
            Console.WriteLine();

            Console.Write("Zadej celé číslo: ");
            int cislo;

            
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.Write("Neplatný vstup, zadejte prosím celé číslo: ");
            }

            int puvodni = cislo;

            
            if (cislo < 0)
                cislo = -cislo;

            int soucet = 0;
            int soucin = 1;

            
            while (cislo > 0)
            {
                int cifra = cislo % 10;
                soucet += cifra;
                soucin *= cifra;
                cislo /= 10;
            }

            Console.WriteLine();
            Console.WriteLine($"Součet cifer čísla {puvodni} je {soucet}");
            Console.WriteLine($"Součin cifer čísla {puvodni} je {soucin}");

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}

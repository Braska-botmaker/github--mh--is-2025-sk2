string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Konvergentní řady **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Horák ******************");
    Console.WriteLine("************** 4.12.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    
    
    
    //načti přesnost
    Console.Write("Zadejte počet členů řady pro výpočet pí (např. 1000000): ");
    int precision; 

    while (!int.TryParse(Console.ReadLine(), out precision) || precision <= 0)
    {
        Console.Write("Nezadali jste platné číslo. Zadejte počet členů řady znovu: ");
    }


   



    // výpočet hodnoty pí
    double pi = 0.0; 
    for (int n = 0; n < precision; n++)
    {
        double člen = Math.Pow(-1, n) / (2 * n + 1);
        pi += člen;
    }


   




    pi *= 4;
    Console.WriteLine($"Hodnota pí vypočtená pomocí konvergentní řady je: {pi}");


    


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
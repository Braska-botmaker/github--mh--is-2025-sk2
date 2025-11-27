string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************** převod 10to2 ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Horák ******************");
    Console.WriteLine("************** 8.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte desítkové číslo (přirozené číslo): ");
    uint number; // číslo v desítkové soustavě
    while (!uint.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte desítkové číslo znovu: ");
    }

    // speciální případ 0
    if (number == 0)
    {
        Console.WriteLine();
        Console.WriteLine("Desítkové číslo 0 v dvojkové soustavě je: 0");
    }
    else
    {
        uint number10 = number;         // kopie pro výpočty
        uint[] myArray = new uint[32];  // max 32 bitů pro uint
        int i = 0;

        // převod do dvojkové soustavy
        while (number10 > 0)
        {
            uint zbytek = number10 % 2;
            myArray[i] = zbytek;
            number10 /= 2; // tady se to musí snížit!

            Console.WriteLine("Celá část: {0}, zbytek: {1}", number10, zbytek);
            i++;
        }

        Console.WriteLine();
        Console.Write("Desítkové číslo {0} v dvojkové soustavě je: ", number);

        // reverzní výpis z pole (už jako int)
        for (int j = i - 1; j >= 0; j--)
        {
            Console.Write(myArray[j]);
        }

        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}

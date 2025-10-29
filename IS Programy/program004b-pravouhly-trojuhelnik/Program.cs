string again = "a";
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Vykreslení obrazců *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Horák ******************");
    Console.WriteLine("************** 29.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte výšku trojúhelníku: ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku znovu: ");
    }

    Console.WriteLine();

    // vykreslení pravoúhlého trojúhelníku
    for (int i = 1; i <= height; i++)  // i = číslo řádku
    {
        for (int j = 1; j <= i; j++)   // j = počet hvězdiček v řádku
        {
            Console.Write("*");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
        }
        Console.WriteLine(); // přejde na nový řádek
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}

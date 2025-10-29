string again = "a";
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Prázdný kosočtverec ***********");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Horák ******************");
    Console.WriteLine("************** 29.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadej lichou velikost: ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n < 3)
    {
        Console.Write("Nezadali jste celé číslo >= 3. Zadejte znovu: ");
    }

    if (n % 2 == 0)
    {
        Console.WriteLine("Poznámka: liché číslo vypadá lépe, zvyšuji o 1.");
        n++;
    }

    Console.WriteLine();

    int mid = n / 2;
    int radius = mid;

    for (int r = 0; r < n; r++)
    {
        for (int c = 0; c < n; c++)
        {
            int dist = Math.Abs(r - mid) + Math.Abs(c - mid);
            Console.Write(dist == radius ? "*" : " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskni klávesu a");
    again = Console.ReadLine();
}

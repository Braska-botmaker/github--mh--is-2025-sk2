string again = "a";
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** Obrazec # ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Horák ******************");
    Console.WriteLine("************** 29.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadej velikost: ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n < 3)
    {
        Console.Write("Nezadali jste celé číslo >= 3. Zadejte znovu: ");
    }

    int r1 = n / 3;
    int r2 = (2 * n) / 3;
    int c1 = n / 3;
    int c2 = (2 * n) / 3;

    Console.WriteLine();

    for (int r = 0; r < n; r++)
    {
        for (int c = 0; c < n; c++)
        {
            bool isRow = (r == r1 || r == r2);
            bool isCol = (c == c1 || c == c2);
            Console.Write(isRow || isCol ? "*" : " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskni klávesu a");
    again = Console.ReadLine();
}

string again = "a";
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** Obrazec N ******************");
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

    Console.WriteLine();

    for (int r = 0; r < n; r++)
    {
        for (int c = 0; c < n; c++)
        {
            bool left = (c == 0);
            bool right = (c == n - 1);
            bool diag = (c == r);
            Console.Write(left || right || diag ? "*" : " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}

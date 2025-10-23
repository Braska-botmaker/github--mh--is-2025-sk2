string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Vykreslení obrazců *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Horák ******************");
    Console.WriteLine("************** 23.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    
    
    

    
    Console.Write("Zadejte šířku obdelníku:");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku obdelníku znovu znovu: ");
    }

     Console.Write("Zadejte výšku obdelníku:");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obdelníku znovu: ");
    }



    for (int i = 0; i <= height; i++)
       {
        for (int j = 1; j <= width; j++)
        {
            Console.Write("*");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
        }
        Console.WriteLine();
         }







    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
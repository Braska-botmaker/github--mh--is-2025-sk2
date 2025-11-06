string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************************************");
    Console.WriteLine("***********Generátor pseudonáhodných čísel ***************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("*********************Matěj Horák *************************");
    Console.WriteLine("********************* 6.11.2025 **************************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine();

    
    
    

    
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet znovu: ");
    }

    Console.Write("Zadejte dolní mez(celé číslo): ");
    int LowerBound;
    while (!int.TryParse(Console.ReadLine(), out LowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

     Console.Write("Zadejte horní mez mez(celé číslo): ");
    int UpperBound;
    while (!int.TryParse(Console.ReadLine(), out UpperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }







    Console.WriteLine();
    Console.WriteLine("========================================================================");
    Console.WriteLine("Zadané hodnoty");
    Console.WriteLine("Počet čísel {0}, dolní mez {1} horní mez {2}", n, LowerBound, UpperBound);
    Console.WriteLine("=======================================================================");
    Console.WriteLine();



    //deklerace pole (erray)
    int[] myRandomNumbers = new int[n];

    //příprava pro využití třídy random
    Random myRandomNumb = new Random();

    //kladná, záporná čísla, nuly
    int negativeNumbers = 0;
    int positiveNumbers = 0;
    int zeroNumbers = 0;

    //sudá nebo lichá
    int evenNumbers = 0;
    int oddNumbers = 0;



    Console.WriteLine();
    Console.WriteLine("Generovaná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandomNumbers[i] = myRandomNumb.Next(LowerBound, UpperBound + 1);
        Console.Write("{0}; ", myRandomNumbers[i]);

        if (myRandomNumbers[i] > 0)
            positiveNumbers++;

        else if (myRandomNumbers[i] < 0)
            negativeNumbers++;
        else
            zeroNumbers++;

    
    if (myRandomNumbers[i] % 2 == 0)
        evenNumbers++;
    else
        oddNumbers++;
}
    


    Console.WriteLine();
    Console.WriteLine("===============================================================");
    Console.WriteLine("Souhrn:");
    Console.WriteLine("Kladných čísel: {0}", positiveNumbers);
    Console.WriteLine("Záporných čísel: {0}", negativeNumbers);
    Console.WriteLine("Nul: {0}", zeroNumbers);
    Console.WriteLine("Sudých čísel: {0}", evenNumbers);
    Console.WriteLine("Lichých čísel: {0}", oddNumbers);
    Console.WriteLine("===============================================================");



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
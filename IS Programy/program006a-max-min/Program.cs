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

    Console.WriteLine();
    Console.WriteLine("Generovaná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandomNumbers[i] = myRandomNumb.Next(LowerBound, UpperBound+1);
        Console.Write("{0}; " ,myRandomNumbers[i]);
    }

    //hledání maxima a minima
    int max = myRandomNumbers[0];
    int min = myRandomNumbers[0];
    int posMax = 0;
    int posMin = 0;
    
    
    for(int i = 1; i < n ; i++)
    {
        if(myRandomNumbers[i] > max)  
        {
            max = myRandomNumbers[i];
            posMax = i;
        }
        
        if(myRandomNumbers[i] < min)  
        {
            min = myRandomNumbers[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("==========================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice minima: {posMin}");
    Console.WriteLine("==========================================");
    Console.WriteLine();

    //Vykreslení přesýpacích hodin
if (max >= 3)
    {
        Console.WriteLine();
        Console.WriteLine("========================================================================= ");
        Console.WriteLine($"Přesýpací hodiny o velikosti {max}:");
        Console.WriteLine();

        for (int i = 0; i < max; i++)
        {
            int spaces;
            int stars;

            if (i < max / 2)
            {
                // horní polovina
                spaces = i;
            }
            else
            {
                // dolní polovina
                spaces = max - i - 1;
            }

            stars = max - 2 * spaces;

            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < stars; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine("========================================================================= ");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("========================================================================= ");
        Console.WriteLine("Přesýpací hodiny pro maximum nelze vykreslit, protože maximum je menší než 3.");
        Console.WriteLine("========================================================================= ");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
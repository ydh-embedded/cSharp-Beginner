using System.Security.Cryptography; 
using static System.Math;
using static System.Console;
using static System.Random;

namespace Structures;

public class Prg
{
    static void Main(string[] args)
    {
        // mIfStatement();
        // mWhileLoop();
    }


    static void mIfStatement()
    {
        var rng = new Random(); // Random Number Generator
        int age = rng.Next(5, 25); // Zufallszahl zwischen 5 und 25
        if (age >= 18)
        {
            WriteLine($"Mit {age} Jahren bist du volljährig");
        }
        else if (age <= 13)
        {
            WriteLine($"Mit {age} Jahren bist du noch ein Teenager, in {18 - age} Jahre bist du volljährig!");
        }
        else
        {
            WriteLine($"Mit {age} Jahren musst du noch {18 - age} Jahre warten, bis du volljährig wirst!");
        }
    }


    static void mWhileLoop()
    {
        int iNumberOfSixes = 0;
        int iTotalRolls = 0;
        // Random rng = new Random(); 
        Random rng = new(); // Kurzform
        while (iNumberOfSixes < 10)
        {
            int value = rng.Next(1, 6 + 1); // Zufallszahl im Bereich 1 bis 6
            iTotalRolls++;
            if (value == 6)
            {
                iNumberOfSixes++;

            }

            WriteLine($"Nach {iTotalRolls} Würfen, haben wir {iNumberOfSixes} die 6 gewürfelt.");
        }

    }


    static void mDoWhileLoop()
    {
        // HashSet<int> vLottoNumberSet = new HashSet<int>();
        HashSet<int> vLottoNumberSet = new();
        // RandomNumberGenerator rng = new();
        Random iRandomNumberGenerator = new();
        do
        {
            int iNumber =
                iRandomNumberGenerator.Next(1, 49 + 1);
            vLottoNumberSet.Add(iNumber);
        } while (vLottoNumberSet.Count < 7);

        List<int> vSortetLottoNumbers = vLottoNumberSet.ToList();
        vSortetLottoNumbers.Sort();
        foreach (int iNumber in vSortetLottoNumbers)
        {
            // WriteLine(vSortetLottoNumbers);
            WriteLine($"{{iNumber:D2}}");
        }
    }


    static void mForLoop()
    {
        int[] primes = [2, 3, 5, 7, 11, 13, 17];
        for (int i = 0; i < primes.Length; i++)
        {
            Console.Write($"{primes[i]:D2} ");
        }
        Console.WriteLine();
        
        Console.WriteLine(primes[primes.Length -1 ]);
        Console.WriteLine(primes[^1]);  // letzte Element
        Console.WriteLine(primes[^2]); // vorletze Element
        Index vLastElement = ^1;
        WriteLine(primes[vLastElement]);
    }

    
    static void MForEachLoop()
    {
        foreach (char c in "Hello World")
        {
            bool bIsVowel = "aeiouAEIOU".Contains(c);
            if (!bIsVowel)
            {
                Console.Write($"{c}");
            }
        }

        string[] sNames = { "Alice", "Bob", "Charlie" };
        foreach (string n in sNames)
        {
            Console.Write(n.ToUpper());
        }
    }
}
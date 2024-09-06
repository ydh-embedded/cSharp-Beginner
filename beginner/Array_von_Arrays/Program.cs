
namespace Array_von_Arrays;

class Program
{
static void Main(string[] args)
{
Console.WriteLine(@"

**************************************************************************
  Array in Arrays Tabellen-Form  

  Ein unregelmäßiges Array ist ein Array-von-Arrays, 
  also ist ein int[ ][ ] ein Array von int[ ], 
  von denen jedes unterschiedliche Längen haben und 
  ihren eigenen Block im Speicher belegen kann.
  
  Ein multidimensionales Array (int[,]) 
  ist ein einzelner Speicherblock (im Grunde eine Matrix). 

  
  Es hat immer die gleiche Anzahl von Spalten für jede Zeile.
**************************************************************************");

    int[][] jaggedArr = new int[][]
    {
        new int[] {1, 8, 2, 7, 9},
        new int[] {2, 4, 6},
        new int[] {33, 42}
    };

    // Print top border
    Console.WriteLine("------------");

    for (int k = 0; k < jaggedArr.Length; k++)
    {
        Console.Write("| "); // Print left border
        for (int j = 0; j < jaggedArr[k].Length; j++)
        {
            Console.Write(jaggedArr[k][j]);
            if (j < jaggedArr[k].Length - 1) Console.Write(" | "); // Print vertical line between integers
        }
        Console.Write(" |"); // Print right border
        Console.WriteLine();
    }

    // Print bottom border
    Console.WriteLine("------------");
}
}

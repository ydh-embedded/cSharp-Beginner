namespace _05_0_Arrays;

class Program
{

        static void Main(string[] args)
        {
            int[ ] b = {11, 45, 62, 70, 88};


            Console.WriteLine(  "**************************************************************************" +
                                "  Addition Array  "  +
                                "**************************************************************************");

            Console.WriteLine(b[2]);
            Console.WriteLine(b[3]);


            Console.WriteLine(  "**************************************************************************" +
                                "  Mehrdimensionales Array  "  +
                                "**************************************************************************");
                                
            int[ , ] x = new int[3,4];  // 3 Row 4 Coloumns 

            //NOTE - Initialize the array with some values
            x[0, 0] = 10;
            x[0, 1] = 2;
            x[0, 2] = 3;
            x[0, 3] = 4;

            // Print the first element of the array  //NOTE - Arrays sind immer 0 basierend
            Console.WriteLine(x[0, 0]);


            Console.WriteLine(  "**************************************************************************" +
                                "  Mehrdim. Array in Tabellen-Form  "  +
                                "**************************************************************************");
            int[,] someNums = { { 2, 3 }, { 5, 6 }, { 4, 6 } };

            // Print top border
            Console.WriteLine("------------");

            for (int k = 0; k < 3; k++)
            {
                Console.Write("| "); // Print left border
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(someNums[k, j]);
                    if (j < 1) Console.Write(" | "); // Print vertical line between integers
                }
                Console.Write("|"); // Print right border
                Console.WriteLine();
            }

            Console.WriteLine(" Wir sortieren Das Array");

            int[] arr = {1, 2, 3, 4};

            Array.Reverse(arr);            //arr = {4, 3, 2, 1}

            Array.Sort(arr);              //arr = {1, 2, 3, 4}

            


            // Print bottom border
            Console.WriteLine("------------");
        }

}
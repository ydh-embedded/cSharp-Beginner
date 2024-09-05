namespace Arrays_in_Loops_xp5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte gebe 5 Zahlen ein");

            int[] numbers = new int[5];
            int count = 0;
            while (count <5)
            {
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            //your code goes here
            int sum = 0 ;

            foreach (int x in numbers) {
                if (x % 2 == 0 )
                {
                    sum += x;
                }
            }

            Console.WriteLine(  "**************************************************************************" +
                                "  Addition Loop  "  +
                                "**************************************************************************");


            Console.WriteLine(sum);
    }
}

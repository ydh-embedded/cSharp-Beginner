using System;

public class Program
{
    static void Main(string[] args)
    {
        for(int i = 0; i<=10; i++)
        {
            if(i==5)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}
using System;

class Rabatt
{
    static void Main(string[] args)
    {
        string input;
        bool isMember, isPremiumMember;
        double totalSum, discount;

        Console.Write("Sind Sie Kunde bei uns? (j/n): ");
        input = Console.ReadLine().Trim().ToLower();
        isMember = input == "j";

        totalSum = 0;
        discount = 0;
        isPremiumMember = false;

        if (isMember)
        {
            Console.Write("Sind Sie Premiumkunde? (j/n): ");
            input = Console.ReadLine().Trim().ToLower();
            isPremiumMember = input == "j";
        }

        Console.Write("Wie hoch ist der Bestellwert? ");
        input = Console.ReadLine().Trim();
        totalSum = Convert.ToDouble(input);

        if (!isMember)
        {
            discount = totalSum > 100 ? 2 : 0;
        }
        else
        {
            discount = isPremiumMember ? 10 : 5;
        }

        string memberType = isMember ? (isPremiumMember ? "Premiumkunde" : "Standardkunde") : "Nichtkunde";

        Console.WriteLine($"Als {memberType} erhalten Sie einen Rabatt in Höhe von {discount}% für den Bestellwert {totalSum}.");

    }
}
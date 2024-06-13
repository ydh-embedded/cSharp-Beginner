namespace Tupel;

public class Pro
{
    
    private static void Main(string[] args)
    {
        MTupel();
    }

    private static void MTupel()
    {
        var tPerson = ("Max", 25, 'm');
        tPerson.Item1 = "Sebastian";
        tPerson.Item2 = 33;
        tPerson.Item3 = 'm';
        Console.WriteLine($"Name: {tPerson.Item1} Alter: {tPerson.Item2} Geschlecht: {tPerson.Item3}");

        var tFriend = ("Max", 25, 'm');
        tFriend.Item1 = "Sebastian";
        tFriend.Item2 = 33;
        tFriend.Item3 = 'm';
        Console.WriteLine($"Name: {tFriend.Item1} Alter: {tFriend.Item2} Geschlecht: {tFriend.Item3}");

        var tEnemy = ("Max", 25, 'm');
        tEnemy.Item1 = "Sebastian";
        tEnemy.Item2 = 33;
        tEnemy.Item3 = 'm';
        Console.WriteLine($"Name: {tEnemy.Item1} Alter: {tEnemy.Item2} Geschlecht: {tEnemy.Item3}");

        // Using var for copies as well
        var tPersonCopy = tPerson;
        var tFriendCopy = tFriend;
        var tEnemyCopy = tEnemy;
    }
}
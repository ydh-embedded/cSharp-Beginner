namespace _14_3_Overloading_dance;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"

            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%###%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%##*******##%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@%#***************##%%@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@###*******************###%@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@%%#****************************##%%@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@%%##**********************************##%%@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@###***************************************#*#%@@@@@@@@@@@@@
            @@@@@@@@@@%%##******************+++++++++++******************##%%@@@@@@@@@
            @@@@@@@%##*****************+=-----------------=+*****************###%@@@@@
            @@@@@%##****************=-------------------------=+****************##%@@@
            @@@@##***************+-------------------------------+************####%@@@
            @@@@***************+-----------------------------------+*******#######%@@@
            @@@@**************=------------=+*********+==-----------=***##########%@@@
            @@@@*************-----------+*****************+----------+##%#########%@@@
            @@@@************----------+*********************+----=+*##############%@@@
            @@@@***********----------*************************+*######%+++##*++###%@@@
            @@@@**********+---------**********************#############--=##---###%@@@
            @@@@**********---------+******************####%%#######*===---==---=##%@@@
            @@@@**********---------****************####%###########*==---==---++##%@@@
            @@@@**********---------************####%#################*--+##--=####%@@@
            @@@@**********---------*********####%#################%+------------##%@@@
            @@@@**********=--------+*****###########################+--=**---***##%@@@
            @@@@***********---------+########################%######+--*#*--+#####%@@@
            @@@@***********=---------+#######################*-=*#################%@@@
            @@@@************=---------=*###################*=-----=+*#############%@@@
            @@@@***********##+-----------+*##############+=----------+############%@@@
            @@@@*******#######*-------------=++*****++=-------------+#############%@@@
            @@@@****############+---------------------------------+###############%@@@
            @@@@%###%#%###########+=----------------------------+##%#############%%@@@
            @@@@@%%%#################+=---------------------=+*##############%%%%@@@@@
            @@@@@@@@@%%%%###############*++=-----------==+*###############%%%%@@@@@@@@
            @@@@@@@@@@@@@%%%###############%%#########################%%%%@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@%%%%###################################%%%%@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@%%#############################%#%%%@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@%%#%#######################%%%%@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@%%%%#################%@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%#########%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%####%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@



            **************************************************************************

                    Dance - Overloading

                    In a ballroom dancing competition,
                    each dancer from a pair is evaluated separately,
                    and then their points are summed up to get the total pair score.
                    The program you are given takes the names and
                    the points of each dancer as input and creates a DancerPoints
                    objects for each dancer,
                    using the taken name and score values as parameters for constructors.
                    Complete the given class, using overload + operator
                    to return an new object where the names of
                    dancers are in one string (see sample output) and
                    the score is equal to the sum of their points.
                    The declaration of that object and the output of
                    its points are already written in Main().

                    Definition:

                    The DancerPoints class has two properties:
                    name and points, which are set through the constructor.

                    The + operator is overloaded
                    to take two DancerPoints objects as parameters.
                    It combines the names of the two dancers with an &
                    separator and adds their points together.
                    The resulting DancerPoints object is returned.



            **************************************************************************");
            //REVIEW -   (player_1 = Dave points_1 = 8 , player_2 = Jessica | points_2 = 7)

            //REVIEW - Input
            Console.Write("Enter the name of the first dancer: ");
            string sName_1 = Console.ReadLine();
            Console.Write("Enter the points of the first dancer: ");
            int  iPoints_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name of the second dancer: ");
            string sName_2 = Console.ReadLine();
            Console.Write("Enter the points of the second dancer: ");
            int  iPoints_2 = Convert.ToInt32(Console.ReadLine());


            DancerPoints dancer1 = new DancerPoints(sName_1, iPoints_1);
            DancerPoints dancer2 = new DancerPoints(sName_2, iPoints_2);


            DancerPoints total = dancer1 + dancer2;                          //SECTION - Additional Opperator

            Console.Write("Team: " + total.name + " with " + total.points + " Points: ");

    }
}

public class DancerPoints
{
    public string name { get; set; }
    public int points { get; set; }

    public DancerPoints(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public static DancerPoints operator +(DancerPoints dancer1, DancerPoints dancer2)
    {
        string combinedName = $"{dancer1.name} & {dancer2.name}";
        int combinedPoints = dancer1.points + dancer2.points;
        return new DancerPoints(combinedName, combinedPoints);
    }
}
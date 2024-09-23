namespace _20_1_verschachtelte_classen_copy;

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
            @@@@**********=--------+*****###########################+--=**---***##%@@@
            @@@@***********---------+########################%######+--*#*--+#####%@@@
            @@@@***********=---------+#######################*-=*#################%@@@
            @@@@************=---------=*###################*=-----=+*#############%@@@
            @@@@***********##+-----------+*##############+=----------+############%@@@
            @@@@*******#######*-------------=++*****++=-------------+#############%@@@
            @@@@****############+---------------------------------+###############%@@@
            @@@@%###%#%###########+=----------------------------+##%#############%%@@@
            @@@@@%%%#################+=---------------------=+*###############%%%%@@@@@
            @@@@@@@@@%%%%###############*++=-----------==+*###############%%%%@@@@@@@@
            @@@@@@@@@@@@@%%%###############%%#########################%%%%@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@%%%%###################################%%%%@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@%%#############################%#%%%@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@%%#%#######################%%%%@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@%%%%#################%@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%#########%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%####%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            

            **************************************************************************

                Verschachtelte Klassen
                
                C# unterstützt verschachtelte Klassen:
                eine Klasse, die Mitglied einer anderen Klasse ist.

                wir stellen verschiedene Geräusche der Tiere dar
                Dog and Cat erben und besitzen eigene verschachtelte Klassen

                Die Verwendung von verschachtelten Klassen mit Vererbung
                kann mehrere Vorteile bieten, darunter:

                Verkapselung:   Durch die Kapselung der Klasse Sound
                                innerhalb der Klasse Animal können wir eine klare
                                Beziehung zwischen den beiden Klassen herstellen und
                                den Code lesbarer und wartbarer machen.
                Polymorphismus: Durch die Verwendung von Vererbung und
                                Methodenüberschreibung können wir ein
                                polymorphes Verhalten erzeugen,
                                bei dem die richtige MakeSound()-Methode je nach
                                Tierart aufgerufen wird.
                Wiederverwendbarkeit des Codes: Die Klasse Animal und die darin
                                verschachtelte Klasse Sound können in mehreren
                                Unterklassen wiederverwendet werden,
                                wodurch doppelter Code vermieden und
                                der Code effizienter wird.


            **************************************************************************");



        Dog myDog = new Dog();                   //SECTION - Create a Dog instance
        Dog.Sound myDogSound = new Dog.Sound(); //SECTION - Access the Dog's Sound class and call the MakeSound method
        

                
        Cat myCat = new Cat();                   //SECTION - Create a Cat instance
        Cat.Sound myCatSound = new Cat.Sound(); //SECTION - Access the Cat's Sound class and call the MakeSound method
        
        
        Bird myBird = new Bird();                   //SECTION - Create a Cat instance
        Bird.Sound myBirdSound = new Bird.Sound(); //SECTION - Acces the Bird's Sound class and call the MakeSound method

        
        
        
        myDogSound.MakeSound();                  //SECTION - Output: The dog barks
        myCatSound.MakeSound();                 //SECTION - Output: The cat meows
        myBirdSound.MakeSound();               //SECTION - Output: The bird chirps
    
                // We can also call the Eat method on the Dog and Cat instances
        myDog.Eat(); // Output: The animal eats
        myCat.Eat(); // Output: The animal eats
    }
}

//REVIEW - public class Animal

public class Animal
{
    public class Sound                                        //SECTION - nested class
    {
        public virtual void MakeSound()                     //SECTION - default implementation MakeSound method
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    public void Eat()
    {
        Console.WriteLine("The animal eats");
    }
}

//REVIEW - public class Dog
public class Dog : Animal                               //SECTION - inherit from Animal
{
    public new class Sound : Animal.Sound
    {
        public override void MakeSound()            //SECTION - specific implementation override the nested method
        {
            Console.WriteLine("The dog barks");
        }
    }
}

//REVIEW - public class Cat
public class Cat : Animal
{
    public new class Sound : Animal.Sound
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows");
        }
    }
}

//REVIEW -  public class Bird
public class Bird: Animal
{
    public new class Sound : Animal.Sound
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("The Bird chirps");
        }
    }
}


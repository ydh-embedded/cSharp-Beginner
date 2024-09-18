using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Veerbung;
class Dog : Animal
{
  public Dog() {
    Legs = 4;
  }
  public void Bark() {
    Console.WriteLine("Woof ");
  }
}
class Person
{
  public void Speak()
  {
    Console.WriteLine("Hi there from Method Speak in class Person");
  }
}
class Student : Person
{
    int number;
}
class Teacher : Person
{
    public void GradeAssignment()
    {
        System.Console.WriteLine("Grading Assignment... from Sub-Class Teacher ");
    }
}
class Professor : Teacher
{
    public void PublishResearch()
    {
        System.Console.WriteLine("Publishing research paper... from Sub-Class Professor");
    }
}
class Animal
{
  public int Legs {get; set;}
  public int Age {get; set;}
}

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

                Veerbung Inheritance

                Inheritance allows us to define a class based on another class.
                This makes creating and maintaining an application easy.

                The class whose properties are inherited by another class
                is called the Base class. The class which inherits the properties
                is called the Derived class.

                For example, base class Animal can be used to derive Cat and Dog classes.
                The derived class inherits all the features from the base class,
                and can have its own additional features. 



            **************************************************************************");
            //REVIEW -   (  )

            //REVIEW - Input
            //STUB - Console.Write("Enter the name of the first dancer: ");
            //STUB - string sName_1 = Console.ReadLine();
            //STUB - Console.Write("Enter the points of the first dancer: ");
            //STUB - int  iPoints_1 = Convert.ToInt32(Console.ReadLine());
            //STUB - 
            //STUB - Console.Write("Enter the name of the second dancer: ");
            //STUB - string sName_2 = Console.ReadLine();
            //STUB - Console.Write("Enter the points of the second dancer: ");
            //STUB - int  iPoints_2 = Convert.ToInt32(Console.ReadLine());

            //REVIEW - Wir haben ein Dog Objekt erstellt und die Bark Methode aufgerufen,
            //         die in der Basisklasse Dog deklariert wurde.  (  )
            Dog d = new Dog();
            Console.Write("A Dog has " + d.Legs + " Legs " + " (Inheritance from class Dog) ");
            
            
            d.Bark();

            //REVIEW - Wir haben ein Student Objekt erstellt und die Speak Methode aufgerufen,
            //         die in der Basisklasse Person deklariert wurde.  (  )
            Person person = new Person();
            person.Speak();                             // Output: Hi there

            //REVIEW - Wir haben ein Student Objekt erstellt und die Speak Methode aufgerufen,
            //         die in der Basisklasse Person deklariert wurde.  (  )
            Student student = new Student();
            student.Speak();                            // Output: Hi there

            //REVIEW - Wir haben ein Student Objekt erstellt und die Speak Methode aufgerufen,
            //         die in der Basisklasse Person deklariert wurde.  (  )
            Teacher teacher = new Teacher();
            teacher.Speak();                            // Output: Hi there
            teacher.GradeAssignment();                  // Output: Grading assignment...

            //REVIEW - Wir haben ein Student Objekt erstellt und die Speak Methode aufgerufen,
            //         die in der Basisklasse Person deklariert wurde.  (  )
            Professor professor = new Professor();
            professor.Speak();                          // Output: Hi there
            professor.GradeAssignment();                // Output: Grading assignment...
            professor.PublishResearch();                // Output: Publishing research paper...

            

    }

    
}

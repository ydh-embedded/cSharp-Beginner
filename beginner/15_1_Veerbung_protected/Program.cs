using System;

namespace _15_1_Veerbung_protected
{
    class Person
    {
        protected int iAge { get; set; }
        protected string sName { get; set; }

        public Person(string name)
        {
            sName = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Name: " + sName);
        }
    }

    class Student : Person
    {
        public Student(string name) : base(name) { }

        public override void Speak(){Console.WriteLine("Name: " + sName); }
    }

    class Teacher : Person
    {
        public Teacher(string name) : base(name) { }

        public override void Speak(){Console.WriteLine("Name: " + sName);  }

        public void GradeAssignment(){Console.WriteLine("Grading assignment...");   }
    }

    class Professor : Teacher
    {
        public Professor(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine("Name: " + sName);
        }

        public void PublishResearch()
        {
            Console.WriteLine("Publishing research paper...");
        }
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

            Person person = new Person("John");
            person.Speak();                             // Output: Name: John

            Student student = new Student("Davidoff");
            student.Speak();                            // Output: Name: Davidoff

            Teacher teacher = new Teacher("Ms. Smith");
            teacher.Speak();                            // Output: Name: Ms. Smith
            teacher.GradeAssignment();                  // Output: Grading assignment...

            Professor professor = new Professor("Dr. Johnson");
            professor.Speak();                          // Output: Name: Dr. Johnson
            professor.GradeAssignment();                // Output: Grading assignment...
            professor.PublishResearch();                // Output: Publishing research paper...
        }
    }

}
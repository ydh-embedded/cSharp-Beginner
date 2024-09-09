using System;

namespace destructoren
{
    class Program
    {
class Dog
        {
            public Dog()
            {
                Console.WriteLine("Line 14: Constructor");
            }
            ~Dog()
            {
                Console.WriteLine("Line 17: Destructor");
            }
        }




        static void Main(string[] args)
        {
            Console.WriteLine(@"

            **************************************************************************

                    Destructors 
                    
                    Lassen Sie uns WriteLine-Anweisungen im Destruktor und
                    Konstruktor unserer Klasse einbeziehen und sehen,
                    wie sich das Programm verhält,
                    wenn ein Objekt dieser Klasse erstellt wird und
                    wenn das Programm endet:  

                    The Dog class has two members:

                    The **constructor** public Dog():
                         This is a special method that is called
                         when an object of the Dog class is created.
                         In this case, it simply prints 
                         the message Constructor to the console.
                    
                    The **destructor** ~Dog():
                        This is a special method that is called
                        when an object of the Dog class is about
                        to be garbage collected 
                        (i.e., when its memory is about to be freed).
                        In this case,
                        it simply prints the message Destructor to the console.

            **************************************************************************");
            Console.WriteLine("Line 25: Creating a new Dog object...");
            Dog d = new Dog();

            Console.WriteLine("Line 27: Forcing the garbage collector to run...");
            // Add a GC.Collect() call to force the garbage collector to run
            GC.Collect();
        }
    }
}
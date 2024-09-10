using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _09_statik_members
{
    class Program
    {
        static void Main(string[] args)
        {
                        Console.WriteLine(@"

            **************************************************************************

                    static Members
                    
                    Because of their global nature,
                    static members can be accessed directly using
                    the class name without an object.


                    As you can see,
                    we can access the static variable using
                    the class name: Cat.count.

                    The count variable is shared between all Cat objects.
                    For this class, each time an object is created,
                    the static value is incremented.
                    The program above demonstrates this
                    when 2 is displayed after creating two objects of that class.

                    Summary: 

                    You must access static members using the class name.
                    If you try to access them via an object of that class,
                    you will generate an error.


            **************************************************************************");



            Cat c1 = new Cat();
            Cat c2 = new Cat();
            Console.WriteLine(Cat.count);
        }


        class Cat 
        {
            public static int count=0;
            public Cat() {
                count++;
            }
        }
    }
}
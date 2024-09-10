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
            
            
                    Console.WriteLine(@"
            
            **************************************************************************

                    Static methods

                    Static methods - can access only static members.
                    The Main method is static, as it is the starting point of
                    any program.
                    Therefore any method called directly from Main had to be static.

            **************************************************************************");
            
            Dog.Bark();
            
                    Console.WriteLine(@"
            
            **************************************************************************

                    Static class

                    
                    An entire class can be declared as static.
                    A static class can contain only static members. 
                    You cannot instantiate an object of a static class,
                    as only one instance of the static class can exist in a program.
                    Static classes are useful for combining logical properties and
                    methods. A good example of this is the Math class.

                    It contains various useful properties and
                    methods for mathematical operations. .


                    
                    Math 
                    Math.PI the constant PI.
                    
                    Math.E represents the natural logarithmic base e.
                    
                    Math.Max() returns the larger of its two arguments.
                    
                    Math.Min() returns the smaller of its two arguments.
                    
                    Math.Abs() returns the absolute value of its argument.
                    
                    Math.Sin() returns the sine of the specified angle.
                    
                    Math.Cos() returns the cosine of the specified angle.
                    
                    Math.Pow() returns a specified number raised to the specified power.
                    
                    Math.Round() rounds the decimal number to its nearest integral value.
                    
                    Math.Sqrt() returns the square root of a specified number.

            **************************************************************************");

            Console.WriteLine(Math.Pow(2, 3));
            //Console.WriteLine(Math.Pow(2,))

        }


        class Cat 
        {
            public static int count=0;
            public Cat() {
                count++;
            }
        }

        class Dog
        {
            public static void Bark() {
                Console.WriteLine("Woof");
            }
        }



    }
}
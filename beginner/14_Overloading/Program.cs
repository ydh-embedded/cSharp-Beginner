using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Overloading;

class Program
{
    static void Main(string[] args)
    {
                    Console.WriteLine(@"

            **************************************************************************

                    Operator Overloading

                    Most operators in C# can be overloaded,
                    meaning they can be redefined for custom actions.

                    For example, you can redefine the action of
                    the plus (+) operator in a custom class.

                    Consider the Box class that has iHeight and iWidth properties: 

                    Summary:

                    This is achieved through operator overloading

            **************************************************************************");

            
            Box box1 = new Box("Box_01", 14, 3) ;
            Box box2 = new Box("Box_02", 5, 7)  ;


            System.Console.WriteLine("");
            System.Console.WriteLine("Box 1: "+ box1.ToString());
            System.Console.WriteLine("Box 2: "+ box2.ToString());

                                Console.WriteLine(@" 

            **************************************************************************

                    Addition Operator

                    The issue with your code is that you're trying to add
                    two Box objects together using the + operator,
                    but you haven't defined what that operation should do.
                    In C#, you need to overload the + operator to specify
                    how it should behave when used with your custom class.


                    I added the operator + overload to the Box class,
                    which takes two Box objects as parameters and returns
                    a new Box object with the summed iHeight and iWidth properties.

                    Summary:

                    All arithmetic and comparison operators can be overloaded.
                    For instance, you could define greater than and
                    less than operators for the boxes that would compare
                    the Boxes and return a boolean result.
                    Just keep in mind that when overloading
                    the > greater than - operator,
                    the < less than - operator 
                    should also be defined.

            **************************************************************************");
            Box box3 = box1 + box2 ;
            box3.sName = "Result Box";                                       //ANCHOR - Change the sName of box3
            System.Console.WriteLine($" {nameof(box3)}: {box3}             //NOTE - We added two Boxes");
    }
    class Box //SECTION - class Box
    {
          public int iHeight {get; set;}
          public int iWidth {get; set;}

          public string sName {get; set;}
          public Box(string n,int h, int w)
          {
                sName   = n ; 
                iHeight = h ;
                iWidth  = w ;
          }

          public static Box operator +(Box b1, Box b2)                      //ANCHOR - "+" Overloading
          {
            
            return new Box($"Result Box ({b1.sName} + {b2.sName})", b1.iHeight + b2.iHeight, b1.iWidth + b2.iWidth);
          }

          public static Box operator -(Box b1, Box b2)                      //ANCHOR - "-" Overloading
          {
            
            return new Box($"Result Box ({b1.sName} - {b2.sName})", b1.iHeight + b2.iHeight, b1.iWidth + b2.iWidth);
          }

          public static Box operator *(Box b, int scalar)                   //ANCHOR - "*" Overloading
          {
            return new Box($"Result Box ({b.sName} * {scalar})", b.iHeight * scalar, b.iWidth * scalar);
            
          }



          public override string ToString()                                 //ANCHOR - Override StringTo String                            
          {
            return $"{sName}({iHeight}x{iWidth})";
          }
    } 
}
using System;
using System.Runtime.InteropServices;

namespace destructoren
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"

            **************************************************************************

                    Destructors 
                    
                    In C#, a destructor is also known as a finalizer.
                    It's a special method that's called
                    when an object is being garbage collected.

                    In this example, the MyClass class allocates an unmanaged
                    resource (a block of memory) in its constructor.
                    The ~MyClass() method is the destructor,
                    which is called when an instance of MyClass is being garbage
                    collected. In the destructor,
                    we release the unmanaged resource using Marshal.FreeHGlobal.

                    Note that in C#, it's generally recommended
                    to use a using statement or implement the IDisposable
                    interface to ensure that resources are released
                    in a timely manner, rather than relying on
                    the garbage collector to call the destructor.

                    Summary: 

                    Implemented MyClass with constructor and destructor
                    to illustrate C# garbage collection and resource management.
                    The destructor (~MyClass()) releases unmanaged resources
                    allocated in the constructor, demonstrating best practices
                    for resource cleanup in C#.


            **************************************************************************");







            MyClass obj = new MyClass();
            Console.WriteLine("Line 50:                 obj is in scope");
            Console.WriteLine("Line 52:                 obj is out of scope");
            GC.Collect();                            // Force garbage collection
            Console.WriteLine("Line 54:                 Garbage collection complete");
            Console.ReadLine();
        }
    }

    public class MyClass
    {
        private IntPtr _unmanagedResource;



        public MyClass()
        {
            _unmanagedResource = Marshal.AllocHGlobal(1024);
            Console.WriteLine("Line 65:                 Constructor");
        }
        ~MyClass()
        {
            // Release unmanaged resources here
            Marshal.FreeHGlobal(_unmanagedResource);
            Console.WriteLine("Line 70:                 Destructor");
        }

        public IntPtr UnmanagedResource
        {
            get { return _unmanagedResource; }
        }
    }
}
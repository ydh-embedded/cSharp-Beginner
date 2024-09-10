namespace _10_Konstructor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"

            **************************************************************************

                    Constructor 
                    
                    The this keyword is used inside the class and
                    refers to the current instance of the class,
                    meaning it refers to the current object.

                    One of the common uses of this is to distinguish
                    class members from other data, such as local or formal
                    parameters of a method, as shown in the following example

                    Summary: 

                    Another common use of this is for passing
                    the current instance to a method as parameter:
                    ShowPersonInfo(this);


            **************************************************************************");             

                    Console.WriteLine(@"

            **************************************************************************
            
                    Your answer is correct because you used `this.age`
                    to refer to the `age` variable within the `Print` method.
                    This clearly indicates you are accessing the class's member variable.
                    Good job! However, remember to include `using System;`
                    at the beginning for the `Console` class to work.

            **************************************************************************");
        Person person = new Person("John", 30);

        
        Person.PrintAge();
    }
}


class Person
{
    private string name;
    private int age;

    public string Name { get { return name; } }
    public int Age { get { return age;}}

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void PrintAge()
    {
        Console.WriteLine("Name: " + this.Name + ", Age: " + this.Age + "");
    }
}
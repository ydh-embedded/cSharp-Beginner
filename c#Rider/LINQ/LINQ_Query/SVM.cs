namespace LINQ_Query;


using System;
using System.Collections.Generic;

public class SVM
{
    static void Main(string[] args)
    {
            PersonCollection people = new PersonCollection();

            people.Add(new Person { Name = "John", Age = 30 });
            people.Add(new Person { Name = "Jane", Age = 25 });
            people.Add(new Person { Name = "Bob", Age = 40 });

            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            people.Remove(new Person { Name = "Jane", Age = 25 });

            Console.WriteLine("After removing Jane:");
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        
    }
    
    
}
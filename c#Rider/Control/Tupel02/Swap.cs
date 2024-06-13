namespace Tupel02;

using System;

    [Run(2)]
    public class Swap
    {
        public Swap()
        {
            var data = new Data("Skeet","Jon", "C# in Depth");
            (data.FirstName, data.LastName) = (data.LastName, data.FirstName);
            Console.WriteLine($"{data.FirstName} {data.LastName}: {data.Title}");
        }

        private struct Data
        {
            public Data(
                string firstName,
                string lastName,
                string title)
            {
                FirstName = firstName;
                LastName = lastName;
                Title = title;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
        }
    }

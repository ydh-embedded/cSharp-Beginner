````csharp



var fileName = @"<path to our CSV file>";
var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    Encoding = Encoding.UTF8, // Our file uses UTF-8 encoding
    Delimiter = "," // The delimiter is a comma
};

````

### 2
-   Open the file and create a StreamReader and CsvReader instance. 


````csharp


using (var fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
using (var textReader = new StreamReader(fs, Encoding.UTF8))
using (var csv = new CsvReader(textReader, configuration))
{
    // ...
}
````

### 3 Read the records asynchronously using GetRecordsAsync<T> method.

````csharp

var data = csv.GetRecordsAsync<Person>();

await foreach (var person in data) // Iterate through the collection asynchronously
{
    // Do something with values in each row
}
````





### complete

````csharp
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool IsActive { get; set; }
}

var fileName = @"<path to our CSV file>";
var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    Encoding = Encoding.UTF8, // Our file uses UTF-8 encoding
    Delimiter = "," // The delimiter is a comma
};

using (var fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
using (var textReader = new StreamReader(fs, Encoding.UTF8))
using (var csv = new CsvReader(textReader, configuration))
{
    var data = csv.GetRecordsAsync<Person>();

    await foreach (var person in data) // Iterate through the collection asynchronously
    {
        // Do something with values in each row
    }
}
````


- This example assumes that your CSV file has headers.
- If your CSV file doesn't have headers, you can use the CsvConfiguration object to specify the mapping between the CSV columns and the Person class properties.

Here's an example of how to map the CSV columns to the Person class properties using the ClassMap class:

````csharp
public class PersonMap : ClassMap<Person>
{
    public PersonMap()
    {
        Map(p => p.FirstName).Index(0);
        Map(p => p.LastName).Index(1);
        Map(p => p.Age).Index(2);
        Map(p => p.IsActive).Index(3);
    }
}

var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    Encoding = Encoding.UTF8,
    Delimiter = ",",
    RegisterClassMap = t => t.Add(new PersonMap())
};

using (var fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
using (var textReader = new StreamReader(fs, Encoding.UTF8))
using (var csv = new CsvReader(textReader, configuration))
{
    var data = csv.GetRecordsAsync<Person>();

    await foreach (var person in data) // Iterate through the collection asynchronously
    {
        // Do something with values in each row
    }
}
````
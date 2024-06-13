# IEnumerator is an Interface
-   in C# that allows you to iterate over a collection of items, such as a list or an array. It defines a set of methods and properties that enable you to move through the collection, access the current item, and check if there are more items to iterate over.

Here's a brief overview of the IEnumerator interface and its members:

    -   Current: A property that gets the current item in the collection.
    -   MoveNext(): A method that moves the enumerator to the next item in the collection. It returns true if there is a next item, and false if there are no more items to iterate over.
    -   Reset(): A method that resets the enumerator to the beginning of the collection. This method is not recommended for use, as it can lead to unpredictable behavior in some cases.
    -   Dispose(): A method that releases the resources used by the enumerator. This method is typically called when you are done iterating over the collection.
    -   To use IEnumerator, you typically create a class that implements the IEnumerable interface, which in turn requires you to implement the IEnumerator interface. The IEnumerable interface defines a GetEnumerator method that returns an IEnumerator object, which can then be used to iterate over the collection.

Here's an example of a simple class that implements IEnumerable and IEnumerator:

````csharp

public class MyCollection : IEnumerable<int>
{
    private int[] _numbers = new int[] { 1, 2, 3, 4, 5 };

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < _numbers.Length; i++)
        {
            yield return _numbers[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
````



- In this example, the MyCollection class implements the IEnumerable<int> interface, which requires it to implement the GetEnumerator method. The GetEnumerator method returns an IEnumerator<int> object, which allows you to iterate over the collection of integers.

- The yield return statement is used to return each item in the collection. When the GetEnumerator method is called, it returns an enumerator object that can be used to iterate over the collection.

#### Here's an example of how you could use the MyCollection class in a foreach loop:



`````csharp

MyCollection collection = new MyCollection();

foreach (int number in collection)
{
    Console.WriteLine(number);
}

`````

````csharp
// output

                1: 1
                2: 2
                3: 3
                4: 4
                5: 5
    
````
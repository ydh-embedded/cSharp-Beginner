# 💩 bug

````csharp
<Enumerator>\IEnumerator.cs (3 errors)
      <Enumerator>\IEnumerator.cs:51 ';' or type declaration body expected
      <Enumerator>\IEnumerator.cs:52 Cannot resolve symbol 'GetEnumerator'
      <Enumerator>\IEnumerator.cs:82 Cannot resolve symbol 'GetEnumerator'

````

````csharp
namespace Enumerator;

public interface IEnumerator.GetEnumerator();
{
    return GetEnumerator(); 
}

````

````csharp
using System.Collections;
namespace Enumerator;

public class SVM
{
    private int[] _numbers = new int[] { 1, 2, 3, 4, 5 };
    
    static void Main(string[] args)
    {
        
    }
    
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < _numbers.Length; i++)
        {
            yield return _numbers[i];
        }
    }
}


````


# 🦊 Lösung 

- I see the issue! 😊

The problem is that you're trying to implement the GetEnumerator method as an interface method, which is not correct. In C#, interfaces only define the contract, they don't provide an implementation.

Here's the corrected code:

````csharp
// IEnumerator.cs
namespace Enumerator;

public interface IEnumerator<T>
{
    T Current { get; }
    bool MoveNext();
    void Reset();
}

// SVM.cs
using System.Collections;
using System.Collections.Generic;

namespace Enumerator;

public class SVM : IEnumerable<int>
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

    static void Main(string[] args)
    {
        SVM svm = new SVM();
        foreach (int number in svm)
        {
            Console.WriteLine(number);
        }
    }
}

````


## Changes:

 - I removed the GetEnumerator method from the IEnumerator interface, as it's not a valid interface method.
 - I added the IEnumerable<int> interface to the SVM class, which requires implementing the GetEnumerator method.
 - I implemented the GetEnumerator method in the SVM class, which returns an enumerator that iterates over the _numbers array.
 - I added the IEnumerable.GetEnumerator() method, which is required by the IEnumerable interface.
 - I added a Main method to demonstrate how to use the SVM class.

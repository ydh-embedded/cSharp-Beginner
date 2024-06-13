// SVM.cs
using System.Collections;
using System.Collections.Generic;


namespace Enumerator;
public class SVM : IEnumerable<int>
{
    private int[] _numbers = new int[] { 1, 2, 3, 4, 5 };

    public System.Collections.Generic.IEnumerator<int> GetEnumerator()
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
using System;
using System.Collections.Generic;

namespace _24_0_Collections;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(@"
        
        Collections - List<T> 


        Ein Liste ist ähnlich wie ein Array,
        aber die Elemente in einer Liste können dynamisch
        eingefügt und entfernt werden.

        Die C# generische Sammlung List<T> Klasse erfordert,
        dass alle Elemente vom gleichen Typ T sind.

        List<T> Eigenschaften und Methoden beinhalten:

        Count Eine Eigenschaft,
        die die Anzahl der Elemente in der Liste erhält.

        Item[int i] Holt oder setzt das Element in der Liste
        am Index i. Item ist der Indexer und wird nicht benötigt,
        
        wenn auf ein Element zugegriffen wird.
        Sie müssen nur die Klammern [] und
        den Indexwert in den Klammern verwenden.

            - Add(T t) Fügt ein Element t am Ende der Liste hinzu.
            - RemoveAt(int index) Entfernt das Element an der angegebenen Position (Index) aus der Liste.
            - Sort() Sortiert die Elemente in der Liste.
        
        Jetzt probieren wir List<T> aus:

        
        ");
        // List<T>
        Console.WriteLine("List<T>:");
        List<string> list = new List<string>();
        list.Add("Apple");
        list.Add("Banana");
        list.Add("Cherry");
        Console.WriteLine("List contains:");
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }

        // Dictionary<TKey, TValue>
        Console.WriteLine("\nDictionary<TKey, TValue>:");
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("John", 25);
        dictionary.Add("Alice", 30);
        dictionary.Add("Bob", 35);
        Console.WriteLine("Dictionary contains:");
        foreach (KeyValuePair<string, int> pair in dictionary)
        {
            Console.WriteLine("Name: {0}, Age: {1}", pair.Key, pair.Value);
        }

        // SortedList<TKey, TValue>
        Console.WriteLine("\nSortedList<TKey, TValue>:");
        SortedList<string, int> sortedList = new SortedList<string, int>();
        sortedList.Add("John", 25);
        sortedList.Add("Alice", 30);
        sortedList.Add("Bob", 35);
        Console.WriteLine("SortedList contains:");
        foreach (KeyValuePair<string, int> pair in sortedList)
        {
            Console.WriteLine("Name: {0}, Age: {1}", pair.Key, pair.Value);
        }

        // Stack<T>
        Console.WriteLine("\nStack<T>:");
        Stack<string> stack = new Stack<string>();
        stack.Push("Apple");
        stack.Push("Banana");
        stack.Push("Cherry");
        Console.WriteLine("Stack contains:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

        // Queue<T>
        Console.WriteLine("\nQueue<T>:");
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Apple");
        queue.Enqueue("Banana");
        queue.Enqueue("Cherry");
        Console.WriteLine("Queue contains:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

        // HashSet<T>
        Console.WriteLine("\nHashSet<T>:");
        HashSet<string> hashSet = new HashSet<string>();
        hashSet.Add("Apple");
        hashSet.Add("Banana");
        hashSet.Add("Cherry");
        hashSet.Add("Apple"); // duplicate item
        Console.WriteLine("HashSet contains:");
        foreach (string item in hashSet)
        {
            Console.WriteLine(item);
        }
    }
}
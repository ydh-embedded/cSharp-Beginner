using System;
using System.Collections.Generic;

namespace _24_0_Collections;

class Program
{
    static void Main(string[] args)
    {

        // List<T>
		    List<int> li = new List<int>();
            li.Add(59);
            li.Add(72);
            li.Add(95);
            li.Add(5);
            li.Add(9);
            li.RemoveAt(1); // remove 72
            
            Console.Write("\nList: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " "); // 59  95  5  9
            li.Sort();
            Console.Write("\nSorted: ");
            for (int x = 0; x < li.Count; x++)
                Console.Write(li[x] + " "); // 5  9  59  95



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
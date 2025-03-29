using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    public class MyList<T>
    {
        private List<T> _list; 

        public MyList()
        {
            _list = new List<T>();
        }

        // 1. Add an element to the list
        public void Add(T element)
        {
            _list.Add(element);
        }

        // 2. Remove an element at a specific index and return it
        public T Remove(int index)
        {
            if (index < 0 || index >= _list.Count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            T element = _list[index];
            _list.RemoveAt(index);
            return element;
        }

        // 3. Check if the list contains a specific element
        public bool Contains(T element)
        {
            return _list.Contains(element);
        }

        // 4. Clear all elements from the list
        public void Clear()
        {
            _list.Clear();
        }

        // 5. Insert an element at a specific index
        public void InsertAt(T element, int index)
        {
            if (index < 0 || index > _list.Count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            _list.Insert(index, element);
        }

        // 6. Delete an element at a specific index
        public void DeleteAt(int index)
        {
            if (index < 0 || index >= _list.Count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            _list.RemoveAt(index);
        }

        // 7. Find an element at a specific index
        public T Find(int index)
        {
            if (index < 0 || index >= _list.Count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            return _list[index];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MyList<int>
            MyList<int> myIntList = new MyList<int>();
            myIntList.Add(10);
            myIntList.Add(20);
            myIntList.Add(30);

            Console.WriteLine($"Contains 20: {myIntList.Contains(20)}"); 
            Console.WriteLine($"Element at index 1: {myIntList.Find(1)}");

            myIntList.InsertAt(15, 1);
            Console.WriteLine($"Element at index 1 after insertion: {myIntList.Find(1)}");
            myIntList.DeleteAt(1);
            Console.WriteLine($"Element at index 1 after deletion: {myIntList.Find(1)}");

            Console.WriteLine($"Removed element: {myIntList.Remove(1)}"); 
            Console.WriteLine($"Contains 20: {myIntList.Contains(20)}");

            myIntList.Clear();
            Console.WriteLine($"List cleared. Contains 10: {myIntList.Contains(10)}"); 

            // Create an instance of MyList<string>
            MyList<string> myStringList = new MyList<string>();
            myStringList.Add("Hello");
            myStringList.Add("World");

            Console.WriteLine($"Contains 'World': {myStringList.Contains("World")}"); 
            Console.WriteLine($"Element at index 0: {myStringList.Find(0)}");
        }
    }
}
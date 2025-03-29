using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    public class MyStack<T>
    {
        private List<T> _stack; 

        public MyStack()
        {
            _stack = new List<T>();
        }

        public int Count()
        {
            return _stack.Count;
        }

        public void Push(T item)
        {
            _stack.Add(item);
        }

        public T Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

           
            T item = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1); 
            return item;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {   
            // Int stack
            MyStack<int> intStack = new MyStack<int>();
            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);

            Console.WriteLine($"Stack count: {intStack.Count()}"); 
            Console.WriteLine($"Popped: {intStack.Pop()}"); 
            Console.WriteLine($"Stack count: {intStack.Count()}"); 


            // String stack
            MyStack<string> stringStack = new MyStack<string>();
            stringStack.Push("Hello");
            stringStack.Push("World");

            Console.WriteLine($"Stack count: {stringStack.Count()}"); 
            Console.WriteLine($"Popped: {stringStack.Pop()}"); 
            Console.WriteLine($"Stack count: {stringStack.Count()}"); 
        }
    }
}
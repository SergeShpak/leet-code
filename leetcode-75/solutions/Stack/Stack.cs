using System;
using System.Collections.Generic;

namespace solutions.Stack;

public partial class Solution
{
    private interface IStack<T>
    {
        public void Push(T b);
        public (T?, bool) Pop();
        public (T?, bool) Top();
        public bool IsEmpty();
        public bool IsFull();
        public List<T> GetAll();
    }
    
    private class Stack<T> : IStack<T>
    {
        private List<T> elements;
        private int pos = -1;

        public Stack()
        {
            elements = new List<T>();
        }

        public void Push(T b)
        {
            elements.Add(b);
            pos++;
        }
        
        public (T?, bool) Pop()
        {
            (var el, var isExist) = Top();
            if (isExist)
            {
                elements.RemoveAt(pos);
                pos--;
            }
            return (el, isExist);
        }

        public (T?, bool) Top()
        {
            if (pos == -1)
            {
                return (default, false);
            }

            T el = elements[pos];
            return (el, true);
        }

        public bool IsEmpty()
        {
            return pos == -1;
        }

        public bool IsFull()
        {
            return false;
        }

        public List<T> GetAll()
        {
            return elements;
        }
    }
}
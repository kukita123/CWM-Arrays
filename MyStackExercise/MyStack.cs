using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackExercise
{
    class MyStack
    {
        private List<int> _stack = new List<int>();

        public void Push(int item)
        {
            _stack.Add(item);
        }

        public int Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("There are no elements in the stack");

            int toReturn = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);

            return toReturn;
        }

        public int Peek()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("There are no elements in the stack");

            return _stack[_stack.Count - 1]; 
        }

        public int Count()
        {
            return _stack.Count;
        }

        public bool Contains(int item)
        {
            return _stack.Contains(item) == true; 
        }

        public int[] ToArray()
        {
            int[] array = _stack.ToArray();
            return array;
        }
    }
}

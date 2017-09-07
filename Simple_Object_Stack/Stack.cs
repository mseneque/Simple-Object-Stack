using System;
using System.Collections;

namespace Simple_Object_Stack
{
    partial class Program
    {
        public class Stack
        {
            private readonly ArrayList _stack;

            public Stack()
            {
                _stack = new ArrayList();
            }

            public void Push(object obj)
            {
                if (obj == null)
                    throw new Exception("InvalidOperationException");
                _stack.Add(obj);
            }

            public object Pop()
            {
                if (_stack.Count == 0)
                    throw new Exception("InvalidOperationException");

                var index = _stack.Count - 1;
                var obj = _stack[index];
                _stack.RemoveAt(index);

                return obj;

            }

            public void Clear()
            {
                _stack.Clear();
            }
        }
    }
}

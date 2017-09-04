using System;
using System.Collections;

namespace Simple_Object_Stack
{
    partial class Program
    {
        public class Stack
        {
            private readonly ArrayList _stackList;

            public Stack()
            {
                _stackList = new ArrayList();
            }

            public void Push(object obj)
            {
                if (obj == null)
                    throw new Exception("InvalidOperationException");
                _stackList.Add(obj);
            }

            public object Pop()
            {
                var popIndex = _stackList.Count - 1;

                if (popIndex >= 0)
                {
                    var obj = _stackList[popIndex];
                    _stackList.RemoveAt(popIndex);
                    return obj;
                }

                throw new Exception("InvalidOperationException");

            }

            public void Clear()
            {
                _stackList.Clear();
            }
        }
    }
}

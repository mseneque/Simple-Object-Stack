using System;

namespace Simple_Object_Stack
{
    // A Stack is a data structure for storing a list of elements in a LIFO (last in, first out) fashion.
    // This simple object stack has three methods; Push(), Pop() and Clear()
    // This stack uses the object class, which has the downside of boxing value types to object reference types 
    // when Pushed to the stack, and then unboxing them back to the original value type when Popped back of the stack.
    // Boxing and unboxing comes with a small performance penalty. However, another implementation using generics 
    // will resolve this issue, but hasn't been implemented in this stack class.
    partial class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Clear();

            stack.Push(2);
            stack.Push(DateTime.Today);
            stack.Push("Hello");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();
            stack.Clear();

        }
    }
}

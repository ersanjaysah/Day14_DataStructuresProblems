using System;

namespace UC1_CreateAStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack obj = new Stack();
            obj.Push(70);
            obj.Push(30);
            obj.Push(56);
            obj.Display();
        }
    }
}

using System;

namespace UC6_DeleteLastWithPopMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Pop(2);
            
            list.Display();
        }
    }
}

using System;

namespace UC10_AscendingOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.sort(30);
            list.Display();
        }
    }
}

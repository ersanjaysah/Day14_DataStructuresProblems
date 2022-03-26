using System;

namespace UC4_InsertingData
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(56);
            list.Insert(1,30);
            list.Display();
        }
    }
}

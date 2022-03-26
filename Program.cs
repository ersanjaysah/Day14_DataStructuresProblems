using System;

namespace UC5_DeletingData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Delete(56);
            list.Display();
        }
    }
}

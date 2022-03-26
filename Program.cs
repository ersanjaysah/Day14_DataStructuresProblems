using System;

namespace UC9_ShowSizeLinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Insert(2, 40);
            list.Delete(40);
            int a=list.Size();
            list.Display();
            Console.WriteLine("After deleting Size is=" + a);
        }
    }
}

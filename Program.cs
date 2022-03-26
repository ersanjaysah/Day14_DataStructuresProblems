using System;

namespace UC3_QueueList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            QueueOperation obj = new QueueOperation();
            obj.Enqueue(70);
            obj.Enqueue(30);
            obj.Enqueue(56);
            obj.Display();
        }
    }
}

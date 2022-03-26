using System;

namespace UC4_Dequeue
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

            Console.WriteLine("statrting element is: " + obj.front.key);
            Console.WriteLine("Last element is: " + obj.rear.key);
            Console.WriteLine("Dequeuing elements from the Queue");
            obj.Dequeue();
            obj.Dequeue();
            obj.Dequeue();
            Console.WriteLine("All elements are Dequeued");

        }
    }
}

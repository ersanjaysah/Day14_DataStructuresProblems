using System;

namespace UC2_Stack_PeakAndPop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stacking obj = new Stacking();
            obj.Push(70);
            obj.Push(30);
            obj.Push(56);
            obj.Display();

            Console.WriteLine("picked item from Top is={0}",obj.peak());
            obj.Pop();
            Console.WriteLine("picked item from Top is={0}", obj.peak());
            obj.Pop();
            Console.WriteLine("picked item from Top is={0}", obj.peak());
            obj.Pop();
            obj.peak();
        }
    }
}

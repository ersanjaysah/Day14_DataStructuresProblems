using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_Stack_PeakAndPop
{
    public class Stacking
    {

        internal Node top;

        public bool Push(int data)
        {
            Node n = new Node(data);
            if (top == null)
            {
                top = n;
                Console.WriteLine("{0} inserted into the Stack", n.data);
                return true;
            }
            else
            {
                n.next = top;
                top = n;
                Console.WriteLine("{0} inserted into the Stack", n.data);
                return true;
            }
        }

        public void Pop()
        {
            if(top==null)
            {
                Console.WriteLine("Nothing is in the Stack");
            }
            top = top.next;
        }

        public bool Empty()
        {
            return top == null;
        }

        public int peak()
        {
            if(!Empty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
        }


        public void Display()
        {
            Node t = top;
            if (t == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            while (t != null)
            {
                Console.WriteLine(t.data + " ");
                t = t.next;
            }
        }
    }
}

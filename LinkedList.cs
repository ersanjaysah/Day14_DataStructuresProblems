using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC7_SearchLinkList
{
    public class LinkedList
    {
        internal Node head;

        public bool Add(int data)
        {
            Node n = new Node(data);
            {
                if(head==null)
                {
                    head = n;
                    Console.WriteLine("{0} inserted into the link list", n.data);
                    return true;
                }
                else
                {
                    n.next = head;
                    head = n;
                    Console.WriteLine("{0} inserted into the link list", n.data);
                    return true;
                }
            }
        }

        public bool Search(int data)
        {
           if (head == null)
            
                throw new NullReferenceException("List is Empty");
            
            Node t = head; int count = 0;
            while (t != null)
            {
               count++;
                if (t.data == data)
                    
                    return true;
                    Console.WriteLine("{0} data searched", data);
                    t = t.next;
            }
            return false;
        }
        
        internal void Display()
        {
            Node t = head;
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

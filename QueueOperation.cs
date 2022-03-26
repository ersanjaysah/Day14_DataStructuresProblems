using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_Dequeue
{
    internal class QueueOperation
    {
        internal Node front,rear;
        public void Enqueue(int key)
        {
            Node temp = new Node(key);

            if (this.rear == null)
            {
                this.front = this.rear = temp;
                Console.WriteLine("{0} Enqueued into the Queue",key);
                return;
            }
            this.rear.next = temp;
            Console.WriteLine("{0} Enqueued into the Queue",key);
            this.rear = temp;
        }

        public void Dequeue()
        {
            if (this.front == null)
            {
                return;
            }

            Node temp = this.front;
            this.front = this.front.next;
            if (this.front == null)
            {
                this.rear = null;
            }
        }

        internal void Display()
        {
            Node t = front;
            if (t == null)
            {
                Console.WriteLine(" Queue is Empty");
            }
            while (t != null)
            {
                Console.WriteLine(t.key + " ");
                t = t.next;
            }
        }
    }
}

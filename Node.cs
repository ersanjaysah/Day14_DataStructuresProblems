using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_Dequeue
{
    internal class Node
    {
        public int key;
        public Node next;

        public Node(int key)
        {
            this.key =key;
        }
    }
}

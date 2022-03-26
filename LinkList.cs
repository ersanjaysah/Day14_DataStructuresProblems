using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_SimpleLinkList
{
    public class LinkList
    {
        internal Node head;

        public bool Add(int data)
        {
            Node n = new Node(data);
            if (head==null)
            {
                head = n;
                Console.WriteLine("{0} inserted into the link list",n.data);
                return true;
            }
            else
            {
                n.next = head;
                head = n;
                Console.WriteLine("{0} inserted into the link list",n.data);
                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Node head = new Node(5);
            head.addToTial(20, head);
            head.addToTial(30, head);
            head.print(head);
            Console.WriteLine("-------------------");
            head = head.addToBigening(70, head);
            head.print(head);
            Console.WriteLine("-------------------");
            head.reverseLinkedList(head);
            
            Console.ReadKey();
        }
    }
}

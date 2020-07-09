using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int data { get; set; }
        public Node next { get; set; }

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }

        public void print(Node head)
        {
            Node currentNode = head;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }


        public void reverseLinkedList(Node head)
        {
            Node currentNode = head;
            Node previous = null;

            while(currentNode!=null)
            {
                Node next = currentNode.next;
                currentNode.next = previous;
                previous = currentNode;
                currentNode = next;
            }

            
        }

        public Node addToBigening(int data, Node head)
        {
            Node currentNode = head;
            Node newNode = new Node(data);
            newNode.next = currentNode;
            head = newNode;

            return head;
        }

        public void addToTial(int data, Node head)
        {
            if (head == null)
            {
                Node newHead = new Node(data);
                
            }
            else
            {
                Node currentNode = head;
                Node newNode = new Node(data);

                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }


                currentNode.next = newNode;

               
            }

            
        }
    }
}

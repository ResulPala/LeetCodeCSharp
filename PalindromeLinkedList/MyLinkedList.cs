using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeLinkedList
{
    public class MyLinkedList
    {
        

        public void AddNode(Node head, int data)
        {
            if (head.data == null)
            {
                Node temp = new Node();
                temp.data = data;
                temp.next = null;
                head = temp;
            }
            else
            {
                Node temp = new Node();
                temp.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = temp;
            }
            
        }

        public void Print(Node head)
        {
            Node index = head;
            while (index.next != null)
            {
                Console.WriteLine(index.data);
                index = index.next; 
            }
        }

        
    }

    public class Node
    {
        public int data;
        public Node next;

  
    }
}

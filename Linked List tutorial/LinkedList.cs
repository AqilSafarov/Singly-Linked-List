using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_tutorial
{
   public  class LinkedList
    {
        Node head;
        Node tail;

        public void AddLast(int value)
        {
            Node element = new Node();

            element.Data = value;
            element.next = null;

            if (head==null)
            {
                head = element;
                tail = element;
            }
            else
            {
                tail.next = element; 
                tail = element;
            }
        }

        public void AddFirst(int value)
        {
            Node element = new Node();
            element.Data = value;

            if (head==null)
            {
                head = element;
                tail = element;

            }
            else
            {
                element.next = head; 
                head = element;
            }
        }
        public void Write()
        {
            if (head==null)
            {
                Console.WriteLine("List is empthy");
            }
            else
            {
                Node temp = head;
                Console.Write("Head");
                while (temp!=null)
                {
                    Console.Write($" -> {temp.Data}");
                    temp = temp.next;
                }
                Console.WriteLine(" -> Null");
            }
        }
    }
}

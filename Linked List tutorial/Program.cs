using System;

namespace Linked_List_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
         
            LinkedList list = new LinkedList();
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddFirst(10);
            list.AddLast(50);
            list.AddLast(5);
            list.AddLast(1 );


            list.Write();
        }
    }
}

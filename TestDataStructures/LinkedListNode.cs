using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataStructures
{
    class LinkedListNode
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void Add(string userInput)
        {
            Node newNode = new Node { Next = null, Data = userInput };
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
                Count++;
            }
            else
            {
                //Change the previous reference in the new node
                newNode.Prev = Tail;
                //Change the tail next reference
                Tail.Next = newNode;
                //change the tail
                Tail = newNode;
                Count++;
            }
        }

        public Node GetNode(int index)
        {
            int start = 0;
            Node temp = Head; //mark the start of my search
            while (start != index)
            {
                start += 1;
                temp = temp.Next;
            }
            return temp;
        }

        public void PrintList()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(GetNode(i).Data);
            }
        }
    }
}

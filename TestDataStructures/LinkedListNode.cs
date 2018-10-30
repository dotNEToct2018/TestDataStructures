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
                //Change the tail next reference
                Tail.Next = newNode;
                //change the tail
                Tail = newNode;
                Count++;
            }
        }
    }
}

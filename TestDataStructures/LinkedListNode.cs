using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataStructures
{
    class LinkedListNode
    {
        public Node Head { get; set; } // First Node in the list
        public Node Tail { get; set; } // Last Node in the list
        public int Count { get; set; } // Number of Nodes in the list

        public void Add(string userInput)
        {
            Node newNode = new Node { Data = userInput }; // Create new Node to hold data
            if (Count == 0) // if list is empty
            {
                Head = newNode; // Both Head and Tail point to the new Node
                Tail = newNode;
                Count++;
            }
            else
            {
                // 1. Change the previous reference in the new node
                newNode.Prev = Tail;
                // 2. Change the tail next reference
                Tail.Next = newNode;
                // 3. change the tail
                Tail = newNode;
                Count++;
            }
        }

        public Node GetNode(int index)
        {
            int start = 0;
            Node temp = Head; // Search starts at the first node in the list
            while (start != index)
            {
                start++; // Increment 'start' to continue searching until the index is found
                temp = temp.Next; // Change 'temp' to the next Node in the list
            }
            return temp;
        }

        public bool RemoveAt(int index)
        {
            if (index >= Count || index < 0) // if index is out of range
            {
                return false;
            }

            Node temp = GetNode(index); // Find the Node at the given index
            if (index == 0) // if removing Head
            {
                Head = Head.Next; // change Head to the new Head
                Head.Prev.Next = null; // remove reference to new Head from old Head
                Head.Prev = null; // remove reference to old Head from new Head
            }
            else if (index == Count - 1) // if removing Tail
            {
                Tail = Tail.Prev; // change Tail to the new Tail
                Tail.Next.Prev = null; // remove reference to new Tail from old Tail
                Tail.Next = null; // remove reference to old Tail from new Tail
            }
            else
            {              
                // Change the 'Next' reference of the node BEFORE the selected one
                // to the node AFTER the selected one
                temp.Prev.Next = temp.Next;
                // Change the 'Prev' reference of the node AFTER the selected one
                // to the node BEFORE the selected one
                temp.Next.Prev = temp.Prev;
                // This removes all references to the selected node from the surrounding nodes
            }
            // remove references to surrounding nodes from selected node and clear the data in it
            temp.Next = null;
            temp.Prev = null;
            temp.Data = null;
            // Reduce the number of nodes in the list by 1 (decrement)
            Count--;
            return true;
        }

        public bool InsertAt(int index, Node newNode)
        {
            if (index >= Count || index < 0)
            {
                return false;
            }

            if (index == 0) // if inserting at Head
            {
                newNode.Next = Head; // 1. change newNode's Next to the current Head
                Head.Prev = newNode; // 2. change current Head's Prev to the newNode
                Head = newNode; // 3. change Head to newNode
                Count++; // 4. Increment the Count
                return true;
            }

            if (index == Count - 1) // if inserting at Tail
            {
                newNode.Prev = Tail; // 1. change newNode's 'Prev' to point to the current Tail (previously 'null')
                Tail.Next = newNode; // 2. change current Tail's 'Next' to newNode (previously 'null')
                Tail = newNode; // 3. newNode becomes the new Tail
                Count++; // 4. Increment the Count
                return true;
            }
           
            // OTHERWISE:
            Node nodeAtIndex = GetNode(index); // 1. Find the Node currently at the index      
            newNode.Next = nodeAtIndex; // 2. Change newNode's 'Next' to point to the node whose "spot" (index) it's taking
            newNode.Prev = nodeAtIndex.Prev; // 3. Change the newNode's 'Prev' to point to the node before the index

                // At this point, the newNode's references (Next and Prev) point to
                // the same nodes as the node that was found at the index (nodeAtIndex).
                // We have to change nodeAtIndex's 'Prev' and the node before 
                // nodeAtIndex (nodeAtIndex.Prev) to point to the newNode          

            nodeAtIndex.Prev.Next = newNode; // 1. Change the node before the index to point to the newNode
            nodeAtIndex.Prev = newNode; // 2. Change the node found at the index to point to the newNode
            Count++; // 3. Increment the Count
            return true;
        }

        public void PrintList()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(GetNode(i).Data);
            }
        }

        public void PrintReverse()
        {
            for (int i = Count-1; i >= 0; i--)
            {
                Console.WriteLine(GetNode(i).Data);
            }
        }
    }
}

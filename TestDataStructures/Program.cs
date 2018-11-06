using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode myList = new LinkedListNode();
            myList.Add("Steve");
            myList.Add("Mauricio");
            myList.Add("Evan");
            myList.Add("Dan");
            myList.Add("Ian");

            // Print the count and the list from beginning to end and from end to beginning
            Console.WriteLine("My list's count is " + myList.Count);
            Console.WriteLine();
            myList.PrintList();
            Console.WriteLine();
            myList.PrintReverse();

            // Find the node at index 3
            Node tempNode = myList.GetNode(3);

            // Change its data
            tempNode.Data = "Ty";
            Console.WriteLine();

            // Print the list with the new data
            myList.PrintList();
            Console.WriteLine();

            // Make a new node and give it some data
            Node newNode = new Node();
            newNode.Data = "Mace";

            // Remove the node at index 2
            myList.RemoveAt(2);

            // Insert the new node at the beginning of the list
            myList.InsertAt(0, newNode);

            // Print the list with the new nodes
            myList.PrintList();
        }
    }
}

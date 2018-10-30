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

            Console.WriteLine("My list's count is " + myList.Count);
            Console.WriteLine();
            myList.PrintList();
            Node tempNode = myList.GetNode(3);
            tempNode.Data = "Ty";
            Console.WriteLine();
            myList.PrintList();
        }
    }
}

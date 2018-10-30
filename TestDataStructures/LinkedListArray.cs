using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataStructures
{
    class LinkedListArray
    {
        private string[] items = new string[100];
        private int Count = 0;

        public int Length()
        {
            return Count;
        }

        public bool Insert(string newItem)
        {
            if(Count == items.Length)
            {
                return false;
            }
            items[Count] = newItem;
            Count++;
            return true;
        }

        public bool IsEmpty()
        {
            if(Count == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsFull()
        {
            if (Count == items.Length)
            {
                return true;
            }
            return false;
        }

        public void PrintList()
        {
            int counter = 0;
            Console.WriteLine("start of list -> ");
            while(counter < Count)
            {
                Console.Write(items[counter]);
                Console.Write(" -> ");
                counter++;
            }
            Console.WriteLine("end of list");
        }
    }
}
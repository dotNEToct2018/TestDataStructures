using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataStructures
{
    class Node
    {
        public string Data { get; set; } // Whatever data the node holds, this can be multiple fields/properties
        public Node Next { get; set; } // Points to the next node in the list
        public Node Prev { get; set; } // Points to the previous node in the list
    }
}

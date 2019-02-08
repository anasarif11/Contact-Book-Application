using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApplication
{
    class Node
    {
        public string data { get; set; }
        public Node next { get; set; }
        public Node(string val)
        {
            this.data = val;
            this.next = null;
        }
    }
}

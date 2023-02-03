using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Node
    {
        public int Data { get; set; }
        public Node? right { get; set; }
        public Node? left { get; set; }

        public Node(int Data)
        {
            this.Data = Data;
            right = null;
            left = null;
        }

        public bool isLeaf()
        {
            if (right == null && left == null)
                return true;
            return false;
        }
    }
}

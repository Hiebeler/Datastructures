using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack<T>
    {
   
            List<Node> list = new List<Node>();

            public void push(Node item)
            {
                list.Add(item);
            }

            public void pop()
            {
                list.RemoveAt(list.Count - 1);
            }

            public int size()
            {
                return list.Count();
            }
        
    }
}

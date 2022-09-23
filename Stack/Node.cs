using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Node
    {
        object data;
        Node previous;
        public Node GetPrevious() { return previous; }
        public void SetData<T>(T argData)
        {
            data = (object)argData;
        }
        public T getData<T>()
        {
            return (T)data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonPattern
{
    internal class King
    {
        private String Name;
        private static King? ourKing;

        private King()
        {
        }

        public static King GetInstance()
        {
            if (ourKing == null)
            {
                ourKing = new King();
            }

            return ourKing;
        }

        public void SetName(String name)
        {
            Name = name;
        }

        public String Attack()
        {
            return Name + " wants to Attack";
        }

        public String Retriev()
        {
            return Name + " wants to Retriev";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    internal class GenericList<T>
    {
        private List<T> list = new List<T>();
        public void Add(T input)
        {
            list.Add(input);
        }

        List<T> getList()
        {
            return list;
        }
    }
}

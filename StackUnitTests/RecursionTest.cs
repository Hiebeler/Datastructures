using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace DatastructurTests
{
    public class RecusionTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_FixNumber_ReturnsCorrectSum()
        {
            MySum ms = new MySum();
            var recursive = ms.SumUpValues_Recursive(6);
            var iterative = ms.SumUpValues_Iterative(6);
            Assert.AreEqual(recursive, iterative);
        }

        [Test]
        public void faculty_FixNumber_ReturnsCorrectFaculty()
        {
            MyFaculty mf = new MyFaculty();
            var recursive = mf.faculty(6);
            Assert.AreEqual(recursive, 720);
        }

        private class MySum
        {
            public int SumUpValues_Iterative(int number)
            {
                var ret = 0;
                for (int i = 1; i <= number; i++)
                    ret += i;
                return ret;
            }

            public int SumUpValues_Recursive(int number)
            {
                if (number == 1) 
                    return number;
                return number + SumUpValues_Recursive(number - 1);
            }

        }

        private class MyFaculty
        {
            public int faculty(int number)
            {
                if (number == 1)
                    return number;
                return number * faculty(number - 1);
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_course
{
    internal class MyStack : MyList, IMyList
    {
        void IMyList.Add(Person obj)
        {
            
        }

        Person IMyList.Get()
        {
           return null;
        }

        Person IMyList.Remove()
        {
            return null;
        }
    }
}
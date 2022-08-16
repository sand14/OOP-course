using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_course
{
    internal interface IMyList
    {
        void Add(Person obj);
        Person Remove();
        Person Get();
    }
}
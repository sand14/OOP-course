using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course
{
    internal abstract class Poligon
    {
        private int nrLaturi;
        public void AfisareNrLaturi()
        {
            Console.WriteLine($"Nr laturi: {nrLaturi}");
        }
        public abstract double CalcularePerimetru(int, double);
        public abstract double CalculareArie();
    }
}

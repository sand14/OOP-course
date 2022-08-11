using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_course
{
    internal class Patrat : Poligon,IPoligon
    {
        private int nrLaturi=4;
        private double lungimelatura;

        public Patrat(double input)
        {
            lungimelatura=input;
        }
        public override double CalcularePerimetru()
        {
            return 4*lungimelatura;
        }
        public override double CalculareArie()
        {
            return Math.Pow(lungimelatura,2);
        }

        public override string ToString()
        {
            return "Patrat: \nNumar Laturi: 4\nLungime latura: " + lungimelatura + "\nPerimetru: " + CalcularePerimetru() + "\nArie: " + CalculareArie() ;
        }
    }
}
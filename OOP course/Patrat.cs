using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_course
{
    internal class Patrat : Poligon,IPoligon
    {
        private double lungimelatura;

        public Patrat(double input, int nrlaturi = 4) : base(nrlaturi)
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
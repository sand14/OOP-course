using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course
{
    internal class Triunghi : Poligon
    {
        private double lungime1;
        private double lungime2;
        private double lungime3;

        public override double CalcularePerimetru(int nrLaturi, double lungimeLatura)
        {
            return nrLaturi * lungimeLatura;
        }
        public override double CalculareArie(int nrLaturi, double lungimeLatura)
        {
            return nrLaturi * lungimeLatura;
        }


       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course
{
    internal class Triunghi : Poligon,IPoligon
    {
        private double lungime1;
        private double lungime2;
        private double lungime3;

        private double arie;
        private double semiperimetru;

         public Triunghi(double input1,double input2,double input3,int nrlaturi=3) : base (nrlaturi)
        {
            lungime1=input1;
            lungime2=input2;
            lungime3=input3;
        }
        public override double CalcularePerimetru()
        {
            return lungime1 + lungime2 + lungime3;
        }
        public override double CalculareArie()
        {
            semiperimetru = CalcularePerimetru()/2;
            arie=Math.Sqrt(semiperimetru*(semiperimetru-lungime1)*(semiperimetru-lungime2)*(semiperimetru-lungime3));
            return arie;
        }
        public override string ToString()
        {
            return "Triungi: \nNumar Laturi: 3\nLungime laturi: " + lungime1 + " " + lungime2 + " " + lungime3 + " " + "\nPerimetru: " + CalcularePerimetru() + "\nArie: " + CalculareArie() ;
        }


       
    }
}

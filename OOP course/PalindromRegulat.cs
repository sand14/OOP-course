using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course.PalindromRegulat
{
 
    public class PalindromRegulat
    {
        private int nrLaturi;
        private float lungimeLaturi;
        public PalindromRegulat(int nrLaturi, float lungimeLaturi)
        {
            this.nrLaturi = nrLaturi;
            this.lungimeLaturi = lungimeLaturi;
        }
        public float Arie()
        {
            double ariePoligon = (nrLaturi * Math.Pow(lungimeLaturi, 2)) / 4 * (1 / Math.Tan(Math.PI / nrLaturi));
            return (float)ariePoligon;
        }

        public static float Arie(int nrLaturi,float lungimeLaturi)
        {
            double ariePoligon = (nrLaturi * Math.Pow(lungimeLaturi, 2)) / 4 * (1 / Math.Tan(Math.PI / nrLaturi));
            return (float)ariePoligon;
        }
        public float Perimetru()
        {
            return nrLaturi * lungimeLaturi;
        }
        public static float Perimetru(int nrLaturi,float lungimeLaturi)
        {
            return nrLaturi * lungimeLaturi;
        }
        public float RazaCercCircumscris()
        {
            double raza = lungimeLaturi / (2 * Math.Sin(Math.PI / nrLaturi));
            return (float)raza;
        }
        public static float RazaCercCircumscris(int nrLaturi,float lungimeLaturi)
        {
            double raza = lungimeLaturi / (2 * Math.Sin(Math.PI / nrLaturi));
            return (float)raza;
        }
    }
}

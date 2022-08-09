using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_course.Cercuri
{
    class Cerc1
    {
        public Cerc1(double r)
        {
            this.r = r;
        }
        const double PI = 3.141592653589793;
        internal double r;
        internal double Arie()
        {
            return PI * r * r;
        }
        internal double Circumferinta()
        {
            return 2 * PI * r;
        }
    }
    class Cerc2
    {
        const double PI = 3.141592653589793;
        internal static double Arie(double r)
        {
            return PI * r * r;
        }
        internal static double Circumferinta(double r)
        {
            return 2 * PI * r;
        }
    }
}
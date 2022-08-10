using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course
{
    public class S1
    {
        public int a;
        protected double b;
        protected int c;
        public const int alpha = 12;
        public S1(int a, double b, int c)
        {
            // constructorul clasei S1
            this.a = a; this.b = b; this.c = c;
        }
        private double F1()
        {
            // o metoda privata
            return a * c + b;
        }
        protected virtual int F2()
        {
            // o metoda protejata
            return a + 2 * c;
        }
        public virtual double F3()
        {
            // o metoda publica in care se folosesc F1 si F2
            Console.WriteLine("F3 din clasa S1");
            return 2 * F1() + F2();
        }
        public override String ToString()
        {
            // redefinirea metodei Object.ToString()
            Console.WriteLine("F4 din clasa S1");
            return "(S1: " + a + " " + b + " " + c + ")";
        }
        public static int F4(int k)
        {
            return 2 * k + alpha;
        }
        public virtual double F5()
        {
            Console.WriteLine("F5 din clasa S1");
            return 2 * F1();
        }
    }
}

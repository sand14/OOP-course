using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course
{
    class CD1 : S1
    {
        public CD1(int a, double b, int c) : base(a, b, c)
        {
        }
        protected override int F2()
        {
            // redefinirea metodei F2() din superclasa
            return 2 * a;
        }
        public override double F3()
        {
            // redefinirea metodei F3() din superclasa
            Console.WriteLine("F3 din clasa CD1");
            return F2() + base.F3();
        }
        public static new int F4(int k)
        {
            //ascunderea metodei F4 din clasa S1
            Console.WriteLine("F4 din clasa CD1");
            return k * k + alpha;
        }
        //public new double F5()
        //{
        //    Console.WriteLine("F5 din clasa CD1");
        //    return 3 * F1();
        //}
    }
}

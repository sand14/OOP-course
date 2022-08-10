using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course
{
    class CD2 : S1
    {
        public new int a;
        private double m;

        public double M
        {
            get { return m; }
            set { m = value; }
        }
        public CD2(int a, double b, int c,double m) : base(a, b, c)
        {
            this.a = a;
            this.m = m;
        }
        public override string ToString()
        {
            Console.WriteLine("ToString from CD2");
            return $"(CD2: {a} {b} {c} {m})";
        }
        public void F6(String stringinput)
        {
            Console.WriteLine(stringinput);
        }

    }
}

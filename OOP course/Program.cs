// // See https://aka.ms/new-console-template for more information
using OOP_course.Proba;
using OOP_course.Person;
using OOP_course.CNPClass;
using OOP_course.Cercuri;
using OOP_course.PalindromRegulat;
using System.Linq;
// List<CNP> cnps = new List<CNP>();

// foreach(string s in args)
// {
//     cnps.Add(new CNP(s));
// }
// foreach (CNP cnp in cnps)
// {
//     cnp.Verificare();
// }

// //PalindromRegulat palindrom = new (4, 1);
// //Console.WriteLine(palindrom.Perimetru());
// //Console.WriteLine(palindrom.Arie());
// //Console.WriteLine(palindrom.RazaCercCircumscris().ToString("n1"));
// //Console.WriteLine("");
// //Console.WriteLine(PalindromRegulat.Perimetru(4,1));
// //Console.WriteLine(PalindromRegulat.Arie(4, 1));
// //Console.WriteLine(PalindromRegulat.RazaCercCircumscris(4, 1)/*.ToString("n1")*/);
// double u = 3.65, v = 2.87 * u;
// Console.WriteLine(v);
Proba p1 = new();
Proba p2= new();
p1.d = 5;


Person person1 = new Person("Name1", "Address", "5000314090046");
person1.VerificareCNP();
public class Test
{
    
    public static void Test1()
    {
        Proba p1 = new (),p2;
        p2 = new Proba();
        Console.WriteLine(p1 == p2);
        Console.WriteLine(String.Format("m:{0} n:{1}", Proba.m, Proba.n));
        Console.WriteLine($"a:{p1.a} b:{p1.b} c:{p1.c} d:{p1.d} c1:{p1.c1} c2:{p1.c2} s1:{p1.s1} s2{p1.s2}");
        Console.WriteLine($"a:{p2.a} b:{p2.b} c:{p2.c} d:{p2.d} c1:{p2.c1} c2:{p2.c2} s1:{p2.s1} s2{p2.s2}");
        p1.a = 10;
        p2.a = 13;
        Console.WriteLine();
        Console.WriteLine($"a:{p1.a} b:{p1.b} c:{p1.c} d:{p1.d} c1:{p1.c1} c2:{p1.c2} s1:{p1.s1} s2{p1.s2}");
        Console.WriteLine($"a:{p2.a} b:{p2.b} c:{p2.c} d:{p2.d} c1:{p2.c1} c2:{p2.c2} s1:{p2.s1} s2{p2.s2}");
        Console.WriteLine();
        Proba.m = 10;Console.WriteLine(Proba.m);
        Proba.n = 125;Console.WriteLine(Proba.n);
        Console.WriteLine();
        Console.WriteLine($"a:{p1.a} b:{p1.b} c:{p1.c} d:{p1.d} c1:{p1.c1} c2:{p1.c2} s1:{p1.s1} s2{p1.s2}");
        Console.WriteLine($"a:{p2.a} b:{p2.b} c:{p2.c} d:{p2.d} c1:{p2.c1} c2:{p2.c2} s1:{p2.s1} s2{p2.s2}");
        p1.c1 = 'd';Console.WriteLine(p1.c1);   

    }
    public static bool TestEqual(Proba p2,Proba p3)    //! Aici eroare
    {
        if (p2.a == p3.a && p2.b == p3.b && p2.c == p3.c && p2.d == p3.d && p2.c1 == p3.c1 && p2.c2 == p3.c2 && p2.s1 == p3.s1 && p2.s2 == p3.s2 && p2.s3 == p3.s3)
            return true;
        return false;
    }
}

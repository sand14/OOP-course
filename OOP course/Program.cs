// // See https://aka.ms/new-console-template for more information
using OOP_course.Proba;
using OOP_course.CNPClass;
using OOP_course.Cercuri;
using OOP_course.PalindromRegulat;
using System.Linq;
using OOP_course;
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
//Proba p1 = new Proba();
//Proba p2 = new();
//Console.WriteLine();

//Person person1 = new Person("Name1", "Address", "5000314090046");
//person1.VerificareCNP();
//public class Test
//{

//    public static void Test1()
//    {
//        Proba p1 = new (),p2;
//        p2 = new Proba();
//        Console.WriteLine(p1 == p2);
//        Console.WriteLine(String.Format("m:{0} n:{1}", Proba.m, Proba.n));
//        Console.WriteLine($"a:{p1.a} b:{p1.b} c:{p1.c} d:{p1.d} c1:{p1.c1} c2:{p1.c2} s1:{p1.s1} s2{p1.s2}");
//        Console.WriteLine($"a:{p2.a} b:{p2.b} c:{p2.c} d:{p2.d} c1:{p2.c1} c2:{p2.c2} s1:{p2.s1} s2{p2.s2}");
//        p1.a = 10;
//        p2.a = 13;
//        Console.WriteLine();
//        Console.WriteLine($"a:{p1.a} b:{p1.b} c:{p1.c} d:{p1.d} c1:{p1.c1} c2:{p1.c2} s1:{p1.s1} s2{p1.s2}");
//        Console.WriteLine($"a:{p2.a} b:{p2.b} c:{p2.c} d:{p2.d} c1:{p2.c1} c2:{p2.c2} s1:{p2.s1} s2{p2.s2}");
//        Console.WriteLine();
//        Proba.m = 10;Console.WriteLine(Proba.m);
//        Proba.n = 125;Console.WriteLine(Proba.n);
//        Console.WriteLine();
//        Console.WriteLine($"a:{p1.a} b:{p1.b} c:{p1.c} d:{p1.d} c1:{p1.c1} c2:{p1.c2} s1:{p1.s1} s2{p1.s2}");
//        Console.WriteLine($"a:{p2.a} b:{p2.b} c:{p2.c} d:{p2.d} c1:{p2.c1} c2:{p2.c2} s1:{p2.s1} s2{p2.s2}");
//        p1.c1 = 'd';Console.WriteLine(p1.c1);
//        Console.WriteLine(p1.ToString());

//    }
//    internal static bool TestEqual(Proba p2,Proba p3)    //! Aici eroare
//    {
//        if (p2.a == p3.a && p2.b == p3.b && p2.c == p3.c && p2.d == p3.d && p2.c1 == p3.c1 && p2.c2 == p3.c2 && p2.s1 == p3.s1 && p2.s2 == p3.s2 && p2.s3 == p3.s3)
//            return true;
//        return false;
//    }
//}
// CD2 deriv2= new(4,5,7,10);

// Console.WriteLine(deriv2.ToString());
// S1 s1 = new S1(1, 2, 3);
// S1 s2 = new S1(1, 2, 3);
// s1 = deriv2;
// s2 = deriv2;





// if(s1 is CD2)
// {
//     CD2 s1modis=(CD2)s1; 
// }
// if (s2 is CD2)
// {
//     CD2 s2modis = (CD2)s2;
// }

// CD2 s1modas = s1 as CD2;
// CD2 s2modas = s2 as CD2;
// if(s1modas != null && s2modas != null)
// {
//     Console.WriteLine("Succes");
// }


// S1 s = new S1(1, 2, 3);
// CD2 cdvar = new CD2(1, 2, 3, 4);
// s = cdvar;
// ((CD2)s).F6("stringindwadwadwa");
// int b = 3;
// Console.WriteLine("int: {0}", b);

// class Rectangle{
//     public double Length { get; set; }
//     public double Width { get; set; }
// }

// Triunghi triungi=new Triunghi(6,5,3);
// Patrat patrat = new Patrat (5);
// triungi.AfisareNrLaturi();
// patrat.AfisareNrLaturi();
// Console.WriteLine(patrat.ToString());
// Console.WriteLine();
// Console.WriteLine(triungi.ToString());

// IPoligon interfata1;
// IPoligon interfata2;
// interfata1=triungi;
// interfata2=patrat;

// Console.WriteLine(interfata1.ToString());
TestParam.Test();
class Proba2 { public int a; }

class TestParam
{
    // O metoda in care se modifica valorile propriilor parametri formali / 

    static void ModParam(int k, Proba2 p1, Proba2 p2)
    {
        Console.WriteLine("La intrarea in ModParam:\n” +  k=" + k + " p1.a=" + p1.a + "p2.a=" + p2.a);
        k = -111; // S-a modificat valoarea parametrului k de tip 
        p1.a = -222; // S-a modificat valoarea unui camp al obiectului cu
                     // referinta p1, dar nu insasi referinta p1 
        p2 = new Proba2(); // S-a modificat insasi referinta p2, catre 
                           // o noua instanta a clasei Proba2 
        p2.a = -333; // S-a atribuit valoare campului a al noii 
                     // instante referite prin p2 
        Console.WriteLine("In ModParam dupa modificarile de parametri:\n" + "k=" + k +
         " p1.a=" + p1.a + " p2.a=" + p2.a);
    }

    // Metoda principala 
    public static void Test()
    {
        // Se declara si se initializeaza variabilele 
        int m = 123;
        Proba2 pr1 = new Proba2(), pr2 = new Proba2();
        pr1.a = 333;
        pr2.a = 444;
        Console.WriteLine("In Main inainte de a invoca ModParam:\n" + "m=" + m + " pr1.a=" + pr1.a + " pr2.a = "+ pr2.a); 
        // Se invoca metoda ModParam 
        ModParam(m, pr1, pr2);
        // Se afiseaza valorile parametrilor dupa revenirea din ModParam
        Console.WriteLine("In Main dupa ce s-a invocat ModParam:\n" + "m=" + m + " pr1.a=" + pr1.a + " pr2.a=" + pr2.a);
    }
    
}

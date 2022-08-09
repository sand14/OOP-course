﻿// See https://aka.ms/new-console-template for more information
using OOP_course.CNP;
using OOP_course.PalindromRegulat;
List<CNP> cnps = new List<CNP>();

foreach(string s in args)
{
    cnps.Add(new CNP(s));
}
foreach (CNP cnp in cnps)
{
    cnp.Verificare();
}

//PalindromRegulat palindrom = new (4, 1);
//Console.WriteLine(palindrom.Perimetru());
//Console.WriteLine(palindrom.Arie());
//Console.WriteLine(palindrom.RazaCercCircumscris().ToString("n1"));
//Console.WriteLine("");
//Console.WriteLine(PalindromRegulat.Perimetru(4,1));
//Console.WriteLine(PalindromRegulat.Arie(4, 1));
//Console.WriteLine(PalindromRegulat.RazaCercCircumscris(4, 1)/*.ToString("n1")*/);
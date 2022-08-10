using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_course.CNPClass;

namespace OOP_course.Person
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string cnpstring;
        public CNP cnp = new();

        public Person(string name, string address, string cnpstring)
        {
            Name = name;
            Address = address;
            cnp.cnpString = cnpstring;
        }
        
        public void VerificareCNP()
        {
            cnp.Verificare();
            if (cnp.isCorrect)
            {
                Console.WriteLine("Person Valid");
            }
            else
            {
                Console.WriteLine("Person inValid");
            }
        }
        

    }
}

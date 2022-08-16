using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_course.CNPClass;

namespace OOP_course
{
    public class Person
    {
        private string name;
        private string address;
        public string Name { get; set; }
        public string Address { get; set; }
        private CNP cnp = new();

        public Person(string name, string address, string cnpstring)
        {
            Name = name;
            Address = address;
            cnp.cnpString = cnpstring;
        }
        public override string ToString()
        {
            string returnstring= String.Format("Name: {0}   Address: {1}  CNP: {2}", name, address, cnp.cnpString);
            return returnstring;
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

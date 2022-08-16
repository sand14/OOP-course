using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace OOP_course{
    abstract class MyList 
    {
        List<Person> persons = new List<Person>();
        public MyList(){

        }
        public MyList(List<Person> persons){
            this.persons=persons;

        }
        public void ShowElements()
        {
            foreach(var element in persons){
                Console.WriteLine($"{element}");
            }
        }
    }
}
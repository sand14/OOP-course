using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course.CNP
{
    public class CNP
    {
        
        private String cnpString;

        public String MyProperty
        {
            get { return cnpString; }
            set { cnpString = value; }
        }

        public CNP(string stringInput)
        {
            cnpString = stringInput;
        }





        public void Verificare()
        {
            if (GetLenght() != 13)
            {
                Console.WriteLine("Lungime invalida");
                return;
            }
            if (!AreDigitsOnly())
            {
                Console.WriteLine("Format incorect");
                return;
            }
            char[] chars = cnpString.ToCharArray();
            int[] Aint = Array.ConvertAll(chars, c => (int)Char.GetNumericValue(c));
            int[] expresie = { 2, 7, 9, 1, 4, 6, 3, 5, 8, 2, 7, 9 };
            int sum = 0;
            for (int i = 0; i < expresie.Length; i++)
            {
                sum += Aint[i] * expresie[i];
                switch (i)
                {
                    case 0:
                        if (Aint[i] < 1 | Aint[i] > 8)
                        {
                            Console.WriteLine("Cifra sex incorecta");
                        }

                        break;
                    case 4:
                        int luna = Convert.ToInt32(string.Format("{0}{1}", Aint[i - 1], Aint[i]));
                        if (luna < 1 | luna > 12) Console.WriteLine("Luna invalida");
                        break;
                    case 6:
                        int ziua = Convert.ToInt32(string.Format("{0}{1}", Aint[i - 1], Aint[i]));
                        if (ziua < 1 | ziua > 31) Console.WriteLine("Ziua invalida");
                        break;
                    case 8:
                        int codjudet = Convert.ToInt32(string.Format("{0}{1}", Aint[i - 1], Aint[i]));
                        if (codjudet < 1 | codjudet > 52) Console.WriteLine("Cod judet invalid");
                        break;
                }
            }
            if (sum % 11 < 10 && sum % 11 == Aint[12])
            {
                Console.WriteLine("CNP corect");
            }
            else if (sum % 11 == 10 && Aint[12] == 1)
            {
                Console.WriteLine("CNP corect");
            }
            else
            {
                Console.WriteLine("CNP incorect");
                Console.WriteLine("Cifra validare incorecta");
            }
        }
        private int GetLenght()
        {
            return cnpString.Length;
        }
        private bool AreDigitsOnly()
        {
            bool result = true;
            foreach (char c in cnpString)
            {
                if (c < '0' || c > '9')
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}

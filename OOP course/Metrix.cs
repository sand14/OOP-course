using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_course
{
    public class Metrix
    {
        int lin;
        int col;
        int[,] matrix= new int[100,100];
        public Metrix(int lin, int col){
            this.lin=lin;
            this.col=col;
            int[,] matrix= new int[lin,col];
        }
        public Metrix(){

        }
        public int[,] Suma(Metrix a,Metrix b)
        {
            int[,] sum=new int[100,100];
            for (int i = 0; i < b.lin; ++i)
                for (int j = 0; j < b.col; ++j)
                {
                    sum[i,j] = a.matrix[i,j] + b.matrix[i,j];
                }
            return sum;
        }
        public int[,] Inmultire(Metrix a, Metrix b)
        {
            int[,] c = new int[a.lin, b.col];
            if (a.col != b.lin)
            {
                Console.WriteLine("Matrix multiplication not possible");
            }
            else
            {
                for (int i = 0; i < a.lin; i++)
                {
                    for (int j = 0; j < b.col; j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < a.col; k++)
                        {
                            c[i, j] += a.matrix[i, k] * b.matrix[k, j];
                        }
                    }
                }
            }
            return c;
        }

    }
}
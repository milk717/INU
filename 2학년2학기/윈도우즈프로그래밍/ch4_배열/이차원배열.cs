using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class 이차원배열
    {
        //static void Main(string[] args)
        //{
        //    int[,] Arr = { { 10, 20, 30 }, { 40, 50, 60 } };
        //    for(int i = 0; i< Arr.GetLength(0); i++)
        //    {
        //        for(int j = 0; j<Arr.GetLength(1); j++)
        //        {
        //            Console.Write("{0}\t",Arr[i,j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}
        static void Main(string[] args)
        {
            int[,] Arr = new int[2,4] { { 10, 20, 30,0 }, { 40, 50, 60,0 } };
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1)-1; j++)
                {
                    Arr[i, 3] += Arr[i, j];
                }
            }
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", Arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

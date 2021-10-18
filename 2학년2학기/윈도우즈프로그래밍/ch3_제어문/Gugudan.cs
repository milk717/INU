using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_제어문
{
    class Gugudan
    {
        static void Main(string[] args)
        {
            //1단계
            //for (int i = 0; i < 9; i++)
            //{
            //    Console.Write("2*{0}={1}\t", i, 2 * i);
            //}

            //3단계
            //for(int i = 1; i<=9; i++)
            //{
            //    for(int j = 2; j<=9; j++)
            //    {
            //        Console.Write("{0}*{1}={2:D2} ",j,i,i*j);
            //    }
            //    Console.WriteLine();
            //}

            //4단계
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        if (i < j) break;
            //        Console.Write("{0}*{1}={2} ", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}

            //4단계
            int i, j,cnt = 0;
            for(i = 1; i<=9; i++)
            {
                for(j = 1; j<=3; j++)
                {
                    Console.Write("{0}*{1}={2:D2}\t",j+cnt,i,i*j);
                }
                Console.WriteLine();
                if (i == 9 && j % 3 == 1)
                {
                    if (j + cnt == 10) return;
                    i = 0;
                    j = 1;
                    cnt += 3;
                    Console.WriteLine();
                }
            }
            
        }
    }
}

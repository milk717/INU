using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class 로또번호생성기
    {
        static void Main(string[] args)
        {
            Console.WriteLine("로또 번호 생성기 ");

            Random randNum = new Random();
            int resultNum = 0;

            for(int k = 0; k<20; k++)
            {
                int[] num = new int[46];
                for (int i = 0; i < 6; i++)
                {
                    resultNum = randNum.Next(1, 46);
                    if (num[resultNum] == 1)
                    {
                        resultNum = randNum.Next(1, 46);
                    }
                    else
                    {
                        num[resultNum] = 1;
                    }
                    Console.Write(resultNum + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

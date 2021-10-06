using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class 막대그래프
    {
        static void Main(string[] args)
        {
            string[] name = { "김서방", "나서방", "다서방", "라서방", "마서방", "바서방" };
            int[] score = { 66, 77, 99, 55, 88, 75 };

            for(int i = 0; i<score.Length; i++)
            {
                Console.Write("{0} ",name[i]);
                Console.Write("{0}   ", score[i]);
                int res = score[i] / 10;
                for (int j = 0; j<res; j++)
                {
                    Console.Write("*");
                }
                switch (res)
                {
                    case 6:
                        Console.WriteLine(" D");
                        break;
                    case 7:
                        Console.WriteLine(" C");
                        break;
                    case 8:
                        Console.WriteLine(" B");
                        break;
                    case 9:
                        Console.WriteLine(" A");
                        break;
                    default:
                        Console.WriteLine(" F");
                        break;
                }
            }
        }
    }
}

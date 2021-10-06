using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class 성적처리
    {
        static void Main(string[] args)
        {
            int[,] jumsu = new int[4, 7] { { 1,33,44,57,0,0,0},
                                           { 2,77,88,99,0,0,0},
                                           { 3,55,66,77,0,0,0},
                                           { 4,66,77,88,0,0,0}};
            string[] name = { "KBS", "SBS", "YTN", "MBC" };
            //총점,평균 구하기
            for(int i = 0; i<jumsu.GetLength(0); i++)
            {
                for(int j = 1; j<jumsu.GetLength(1)-3; j++)
                {
                    jumsu[i, 4] += jumsu[i, j];
                }
                jumsu[i, 5] = jumsu[i, 4]/(jumsu.GetLength(1) - 4);
            }
            //석차 구하기
            for (int i = 0; i < jumsu.GetLength(0); i++)
            {
                jumsu[i, 6] = 1;
                for (int j = 0; j < jumsu.GetLength(0); j++)
                {
                    if (jumsu[i, 5] < jumsu[j, 5]) jumsu[i, 6]++;
                }
            }
            //정렬 전 출력하기
            Console.WriteLine("학번\t이름\t국어\t영어\t수학\t총점\t평균\t석차");
            Console.WriteLine("============================================================");
            //for (int i = 0; i < jumsu.GetLength(0); i++)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}",
            //        jumsu[i,0],name[i],jumsu[i,1], jumsu[i,2], jumsu[i, 3], jumsu[i, 4], jumsu[i, 5], jumsu[i, 6]);
            //} 
            for (int i = 0; i < jumsu.GetLength(0); i++)
            {
                for (int j = 0; j < jumsu.GetLength(1); j++)
                {
                    if (j == 1) Console.Write("{0}\t",name[i]);
                    Console.Write("{0}\t",jumsu[i,j]);
                }
                Console.WriteLine();
            }
            //석차순으로 정렬하기
            for(int i = 0; i< jumsu.GetLength(0)-1; i++)
            {
                for(int j = i+1; j<= jumsu.GetLength(0)-1; j++)
                {
                    if(jumsu[i,6] > jumsu[j, 6])
                    {
                        int tmp = jumsu[j, 6];
                        jumsu[j, 6] = jumsu[i, 6];
                        jumsu[i, 6] = tmp;
                        string nameTmp = name[j];
                        name[j] = name[i];
                        name[i] = nameTmp;
                    }
                }
            }
            //석차순으로 출력하기
            Console.WriteLine("========================정렬 후 데이터======================");
            Console.WriteLine("학번\t이름\t국어\t영어\t수학\t총점\t평균\t석차");
            Console.WriteLine("============================================================");
            for (int i = 0; i < jumsu.GetLength(0); i++)
            {
                for (int j = 0; j < jumsu.GetLength(1); j++)
                {
                    if (j == 1) Console.Write("{0}\t", name[i]);
                    Console.Write("{0}\t", jumsu[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

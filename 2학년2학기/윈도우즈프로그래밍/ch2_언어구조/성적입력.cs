using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_Method
{
    class 성적입력
    {
        static void Main(string[] args)
        {
            string num, name;
            int kor, eng, math,tot;
            float aver;
            while (true)
            {
                Console.Write("학번 입력 ");
                num = Console.ReadLine();
                if (num == "-999") break;
                Console.Write("이름 입력 ");
                name = Console.ReadLine();

                Console.Write("국어 입력 ");
                while (true)
                {
                    kor = Convert.ToInt32(Console.ReadLine());
                    if (kor < 0 || kor > 100)
                    {
                        Console.Write("범위 초과됨, 국어점수 다시 입력 ");
                    }
                    else break;
                }
                Console.Write("영어 입력 ");
                while (true)
                {
                    eng = Convert.ToInt32(Console.ReadLine());
                    if (eng < 0 || eng > 100)
                    {
                        Console.Write("범위 초과됨, 영어점수 다시 입력 ");
                    }
                    else break;
                }
                Console.Write("수학 입력 ");
                while (true)
                {
                    math = Convert.ToInt32(Console.ReadLine());
                    if (math < 0 || math > 100)
                    {
                        Console.Write("범위 초과됨, 수학점수 다시 입력 ");
                    }
                    else break;
                }

                tot = Sungjuk.Total(kor, eng, math);
                aver = (float)tot / 3;
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6:F2}\n", num, name, kor, eng, math, tot, aver);
            }
            Console.WriteLine("성적처리 끝");
        }
        
    }
}

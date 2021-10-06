using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_제어문
{
    class hakjum
    {
        static void Main(string[] args)
        {
            int hak;
            string hakjum;
            while (true)
            {
                Console.Write("점수 입력 : ");
                hak = Convert.ToInt32(Console.ReadLine());

                if (hak == -999) break;
                else if ((hak > 100) || (hak < 0))
                {
                    Console.WriteLine("점수 초과");
                    continue;
                }
                hakjum = Hakjum_gyesan(hak);
                Console.WriteLine(hakjum);
            }
        }
        public static string Hakjum_gyesan(int hak)
        {
            string res;
            switch (hak/10)
            {
                case 9:
                    res = "A";
                    break;
                case 8:
                    res = "B";
                    break;
                case 7:
                    res = "C";
                    break;
                case 6:
                    res = "D";
                    break;
                default:
                    res = "F";
                    break;
            }
            return res;
        }

    }
}

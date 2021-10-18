using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_Method
{
    class Jumin
    {
        public static int Clac_Year(int year,int gubun)
        {
            if (gubun == 1 || gubun == 2)    //2000년도 이전에태어남
            {
                return 1900 + year;
            }
            else if (gubun == 3 || gubun == 4)
            {
                return 2000 + year;
            }
            else return -1;
        }

        public static int Clac_Age(int year, int gubun, int age, int c_year)
        {
            return c_year - year + 1;
        }
        public static string Clac_Gubun(int gubun, string gubun1)
        {
            if (gubun == 1 || gubun == 3) gubun1 = "남";
            else if (gubun == 2 || gubun == 4) gubun1 = "여";
            else gubun1 = "에러";
            return gubun1;
        } 
        static void Main(string[] args)
        {
            string Jumin = "", gubun1 = "", this_year = "";
            int year = 0, month = 0, day = 0, gubun = 0, age = 0;
            int c_year = 0;

            Console.WriteLine("주민번호 13자리를 입력하세요 : ");
            Jumin = Console.ReadLine();

            year = Convert.ToInt16(Jumin.Substring(0, 2));
            month = Convert.ToInt16(Jumin.Substring(2, 2));
            day = Convert.ToInt16(Jumin.Substring(4, 2));
            gubun = Convert.ToInt16(Jumin.Substring(6, 1));

            this_year = Convert.ToString(DateTime.Now);
            c_year = Convert.ToInt32(this_year.Substring(0, 4));
            year = Clac_Year(year, gubun);
            age = Clac_Age(year, gubun, age, c_year);
            gubun1 = Clac_Gubun(gubun, gubun1);

            Console.WriteLine("년도는 : {0}", year);
            Console.WriteLine("월는 : {0}", month);
            Console.WriteLine("일는 : {0}", day);
            Console.WriteLine("올해 나이는 : {0}", age);
            Console.WriteLine("성별은 : {0}", gubun1);
        }
    }
}

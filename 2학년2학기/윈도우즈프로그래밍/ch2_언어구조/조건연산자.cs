using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_Method
{
    class 조건연산자
    {
        static void Main(string[] args)
        {
            string a, b, c;
            int a1, b1, c1;
            Console.Write("1 하나의 수 입력 : ");
            a = Console.ReadLine();
            Console.Write("2 하나의 수 입력 : ");
            b = Console.ReadLine();
            Console.Write("3 하나의 수 입력 : ");
            c = Console.ReadLine();
            a1 = Convert.ToInt32(a);
            b1 = Convert.ToInt32(b);
            c1 = Convert.ToInt32(c);
            using_if(a1, b1, c1);
            using_ternaryOperator(a1, b1, c1);
        }
        //if문 사용
        public static void using_if(int a, int b, int c)
        {
            int max = a, min = a;
            if (b > max)max = b;
            if (c > max) max = c;
            if (b < min) min = b;
            if (c < min) min = c;
            Console.WriteLine("if문 사용");
            Console.WriteLine("The Max = {0}\tThe Min = {1}",max,min);
            
        }
        public static void using_ternaryOperator(int a,int b, int c)
        {
            int max = a, min = a;
            max = b > max ? b : max;
            max = c > max ? c : max;
            min = b < min ? b : min;
            min = c < min ? c : min;
            Console.WriteLine("삼항 연산자 사용");
            Console.WriteLine("The Max = {0}\tThe Min = {1}", max, min);
        }
    }
}

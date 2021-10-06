 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_Method
{
    class Method
    {
        //sum 기본형
        /*
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int tot = a + b;
            Console.WriteLine("a + b = {0}",tot);

        }
        */
        //sum 반환값 없는 메소드
        /*
        별로 추천하진 않음. 결과값을 메인으로 리턴해주는 것이 좋음
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            Sum(a, b);
        }
        private static void Sum(int a1, int b1)
        {
            int tot = a1 + b1;
            Console.WriteLine("a + b = {0}",tot);
        }
        */
        //sum 반환값 있는 메소드
        /*
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            int hap = Sum(a, b);
            Console.WriteLine("a + b = {0}", hap);
        }
        private static int Sum(int a1, int b1)
        {
            int tot = a1 + b1;
            return tot;
        }
        */
        //plus 클래스 이용하기
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            int hap = Plus.Sum(a, b);
            Console.WriteLine("a + b = {0}", hap);
        }
    }
}

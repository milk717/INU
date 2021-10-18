using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6_Class
{
    class sbs
    {
        private static string name = "홍서방";
        private int age = 19;
        public static void Print()
        {
            Console.WriteLine("정적 이름은: {0}",name);
        }
        public void Out()
        {
            Console.WriteLine("인스턴스 나이는 : {0}",age);
        }
        public sbs()
        {
            Console.WriteLine("Degault C#");
        }
    }
    class 생성자
    {
        static void Main(string[] args)
        {
            sbs.Print();

            sbs k1 = new sbs();
            k1.Out();
        }
    }
}

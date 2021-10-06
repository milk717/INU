using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_Method
{
    class Method
    {
        static void Main(string[] args)
        {
            Start();
            Hi("매개 변수가 있는 메소드 입니다.");

            int value = Plus(3, 4);
            Console.WriteLine("3 + 4 = {0}",value);

            Print_Out("다른 타입의 매개변수가 여러개 일 때", 3);
        }

        private static void Print_Out(string v1, int v2)
        {
            //throw new NotImplementedException();
            for(int i = 0; i<v2; i++)
            {
                Console.WriteLine("{0}, {1}",i,v1);
            }
        }

        private static int Plus(int v1, int v2)
        {
            //throw new NotImplementedException();
            int c = v1 + v2;
            return c;
        }

        private static void Hi(string a)
        {
            //throw new NotImplementedException();
            Console.WriteLine(a);
        }

        private static void Start()
        {
            Console.WriteLine("매개변수와 반환 값이 없는 메소드");
        }
        
    }
}

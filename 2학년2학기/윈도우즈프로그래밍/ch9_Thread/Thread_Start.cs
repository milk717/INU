using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ch9_Exception_Thread
{
    class Thread_Start
    {
        static void Func_A()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("A : Count = " + i);
            }
        }
        static void Func_B()
        {
            for(int i = 0; i<3; i++)
            {
                Console.WriteLine("B : Count ="+i);
            }
        }
        static void Func_C()
        {
            for(int i = 0; i<7; i++)
            {
                Console.WriteLine("C : Count = "+i);
            }
        }
        static void Main(string[] args)
        {
            Thread th_a = new Thread(Func_A);
            Thread th_b = new Thread(Func_B);
            Thread th_c = new Thread(Func_C);
            //스레드 동작시키면 코드짠 순서대로 동작하는게아니라 시스템 맘대로 뒤죽박죽
            th_a.Start();
            th_b.Start();
            th_c.Start();
        }
    }
}

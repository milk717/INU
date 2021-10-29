using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ch9_Exception_Thread
{
    class Thread_Abortcs
    {
        static Thread th_x = new Thread(FuncA);
        static Thread th_y = new Thread(FuncB);
        static void FuncA()
        {
            for(int i = 0; i<10; i++)
            {
                if (i >= 3)     //3이상일 땐 멈춤
                {
                    th_x.Abort();
                }
                Console.WriteLine("A : Count = " + i);
            }
        }
        static void FuncB()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("B : Count = " + i);
            }
        }
        static void Main(string[] args)
        {
            th_x = new Thread(FuncA);
            th_y = new Thread(FuncB);
            th_x.Start();
            th_y.Start();
        }
    }
}

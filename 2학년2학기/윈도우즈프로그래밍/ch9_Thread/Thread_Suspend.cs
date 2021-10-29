using System;
using System.Threading;

namespace ch9_Exception_Thread
{
    class Thread_Suspend
    {
        static Thread th_a = new Thread(FuncA);
        static Thread th_b = new Thread(FuncB);
        static void FuncA()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(3000);
                Console.WriteLine("A : Count = " + i);
                if (i == 5) th_a.Suspend();     //5출력후 얼음
            }
        }
        static void FuncB()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("B : Count = " + i);
            }
        }
        static void Main(string[] args)
        {
            th_a = new Thread(FuncA);
            th_b = new Thread(FuncB);
            th_a.Start();
            th_b.Start();
        }
    }
}

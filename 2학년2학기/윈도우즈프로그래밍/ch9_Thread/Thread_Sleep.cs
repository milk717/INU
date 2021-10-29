using System;
using System.Threading;

namespace ch9_Exception_Thread
{
    class Thread_Sleepcs
    {
        static Thread th_x = new Thread(FuncA);
        static Thread th_y = new Thread(FuncB);
        static void FuncA()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(3000);
                Console.WriteLine("A : Count = " + i);
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
            th_x = new Thread(FuncA);
            th_y = new Thread(FuncB);
            th_x.Start();
            th_y.Start();
        }
    }
}

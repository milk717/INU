using System;
using System.Threading;

namespace ch9_Exception_Thread
{
    class Thread_Resume
    {
        static Thread th_a1 = new Thread(FuncA);
        static Thread th_b1 = new Thread(FuncB);
        static void FuncA()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(3000);
                Console.WriteLine("A : Count = " + i);
                th_a1.Suspend();        //한번 실행 후 얼음, 누군가가 얼음을 깨줘야함
            }
        }
        static void FuncB()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("B : Count = " + i);
            }
            th_a1.Resume();     //B다실행하고 A깨워주기
        }
        static void Main(string[] args)
        {
            th_a1 = new Thread(FuncA);
            th_b1 = new Thread(FuncB);
            th_a1.Start();
            th_b1.Start();
        }
    }
}

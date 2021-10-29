using System;
using System.Collections;

namespace ch4_배열
{
    class 스택
    {
        static void Main(string[] args)
        {
            Stack St = new Stack();

            St.Push("첫 번째");
            St.Push("두 번째");
            St.Push("세 번째");

            Console.WriteLine(St.Pop());
            Console.WriteLine(St.Pop());
            Console.WriteLine(St.Pop());
            //Console.WriteLine(St.Pop());
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace ch4_배열
{
    class Stack_Generic
    {
        static void Main(string[] args)
        {
            //Using stack
            Stack St1 = new Stack();
            St1.Push(123);
            int garo = (int)St1.Pop();
            Console.WriteLine(garo);

            //Using Generic
            Stack<int> St2 = new Stack<int>();
            St2.Push(567);
            int sero = St2.Pop();
            Console.WriteLine(sero);
        }
    }
}

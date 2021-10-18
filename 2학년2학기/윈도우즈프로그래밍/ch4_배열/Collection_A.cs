using System;
using System.Collections;

namespace ch4_배열
{
    class Collection_A
    {
        static void Main(string[] args)
        {
            ArrayList AL = new ArrayList();
            AL.Add(123);
            AL.Add("hello");
            AL.Add(DateTime.Now);
            AL.Add(123.45);

            for(int i = 0; i<AL.Count; i++)
            {
                Console.WriteLine(AL[i]);
            }
        }
    }
}

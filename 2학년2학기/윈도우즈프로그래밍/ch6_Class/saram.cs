using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6_Class
{
    class saram
    {
        //private string _Name;
        //private int _Age;

        //public string Name
        //{
        //    get { return _Name; }
        //    set { _Name = value; }
        //}

        //public int Age
        //{
        //    get { return _Age; }
        //    set { _Age = value; }
        //}
        public int Age { get; set; }
        public string Name { get; set; }
    }
    public class 속성
    {
        static void Main(string[] args)
        {
            saram c = new saram();
            c.Name = "강감찬이다";
            c.Age = 889;
            Print(c.Name, c.Age);
        }
        private static void Print(string name, int age)
        {
            Console.WriteLine("이름은 {0}, 나이는 {1}",name,age);
        }
    }
}

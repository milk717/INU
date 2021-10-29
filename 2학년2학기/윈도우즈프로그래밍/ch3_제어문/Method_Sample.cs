using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_제어문
{
    class Method_Sample
    {
        /*절차지향적 코드*/
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("사각형의 가로의 길이를 입력하세요 : ");
        //    double a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("사각형의 세로의 길이를 입력하세요 : ");
        //    double b = Convert.ToInt32(Console.ReadLine());

        //    int length = Convert.ToInt32((2 * a) + (2 * b));
        //    double Area = (a * b) / 2;

        //    Console.WriteLine("사각형의 둘레의 길이는 {0} 이고", length);
        //    Console.WriteLine("사각형의 면적의 반은 {0} 이고", Area);

        //    if (a == b)
        //    {
        //        Console.WriteLine("정사각형이다.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("직사각형이다.");
        //    }
        //}

        /*리턴값 없는 메소드를 구현*/
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("사각형의 가로의 길이를 입력하세요 : ");
        //    double a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("사각형의 세로의 길이를 입력하세요 : ");
        //    double b = Convert.ToInt32(Console.ReadLine());

        //    LengthCalc(a, b);
        //    Area_Calc(a, b);
        //    Rectangle_Calc(a, b);
        //}
        //public static void LengthCalc(double a1,double b1)
        //{
        //    int length = Convert.ToInt32((2 * a1) + (2 * b1));
        //    Console.WriteLine("사각형의 둘레의 길이는 {0} 이고", length);
        //}
        //public static void Area_Calc(double a1, double b1)
        //{
        //    double Area = (a1 * b1) / 2;
        //    Console.WriteLine("사각형의 면적의 반은 {0} 이고", Area);
        //}
        //public static void Rectangle_Calc(double a1, double b1)
        //{
        //    if (a1 == b1)
        //    {
        //        Console.WriteLine("정사각형이다.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("직사각형이다.");
        //    }
        //}

        //리턴값 있는 메소드로 구현
        /*리턴값 있는 메소드를 구현*/
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("사각형의 가로의 길이를 입력하세요 : ");
        //    double a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("사각형의 세로의 길이를 입력하세요 : ");
        //    double b = Convert.ToInt32(Console.ReadLine());

        //    int length = LengthCalc(a, b);
        //    Console.WriteLine("사각형의 둘레의 길이는 {0} 이고", length);
        //    double Area = Area_Calc(a, b);
        //    Console.WriteLine("사각형의 면적의 반은 {0} 이고", Area);
        //    string c = Rectangle_Calc(a, b);
        //    Console.WriteLine(" {0} ",c);

        //}
        //public static int LengthCalc(double a1, double b1)
        //{
        //    int length = Convert.ToInt32((2 * a1) + (2 * b1));
        //    return length;
        //}
        //public static double Area_Calc(double a1, double b1)
        //{
        //    double Area = (a1 * b1) / 2;
        //    return Area;
        //}
        //public static string Rectangle_Calc(double a1, double b1)
        //{
        //    string c;
        //    if (a1 == b1)
        //    {
        //        c = "정사각형이다.";
        //    }
        //    else
        //    {
        //        c = "직사각형이다.";
        //    }
        //    return c;
        //}
        /*클래스로 분리하기*/
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 가로의 길이를 입력하세요 : ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("사각형의 세로의 길이를 입력하세요 : ");
            double b = Convert.ToInt32(Console.ReadLine());

            int length = OtherClass.LengthCalc(a, b);
            Console.WriteLine("사각형의 둘레의 길이는 {0} 이고", length);
            double Area = OtherClass.Area_Calc(a, b);
            Console.WriteLine("사각형의 면적의 반은 {0} 이고", Area);
            string c = OtherClass.Rectangle_Calc(a, b);
            Console.WriteLine(" {0} ", c);

        }
    }
}

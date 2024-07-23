using System.Security.Claims;
using System.Threading;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ThirdProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

            //2.Override All System.Object Members(ToString, Equals, GetHasCode) .
            // 3.Define All Required Constructors to Produce this output:
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());
            //Output: Hours: 1, Minutes: 10, Seconds: 15
            Duration D1 = new Duration(3600);
            Console.WriteLine($"D1: {D1.ToString()}");
            //Output: Hours: 1, Minutes: 0, Seconds: 0
            Duration D2 = new Duration(7800);
            //D2.ToString();
            Console.WriteLine($"D2:{D2.ToString()}");
            //Output: Hours: 2, Minutes: 10, Seconds: 0
            Duration D3 = new Duration(666);
            //D3.ToString();
            Console.WriteLine($"D3:{D3.ToString()}");
            //Output: Minutes: 11, Seconds: 6
            //4.Implement All required Operators overloading to enable this Code:
            D3 = D1 + D2;
            Console.WriteLine(" D3 = D1 + D2 ");
            Console.WriteLine($"D3:{D3}");
            D3 = D1 + 7800;
            Console.WriteLine("D3 = D1 + 7800");
            Console.WriteLine($"D3:{D3}");

            D3 = 666 + D3;
            Console.WriteLine(" D3 = 666 + D3 ");
            Console.WriteLine($"D3:{D3}");

            //●	D3 = ++D1(Increase One Minute)
            D3 = ++D1;
            Console.WriteLine("D3 = ++D1");
            Console.WriteLine($"D3:{D3}");
            //●	D3 = --D2(Decrease One Minute)
            D3 = --D2;
            Console.WriteLine("D3 = --D2");
            Console.WriteLine($"D3:{D3}");
            D1 = D1 - D2;
            Console.WriteLine("D1 = D1 - D2");
            Console.WriteLine($"D1:{D1}");
            Console.WriteLine($"D1 > D2:{D1 > D2}");
            Console.WriteLine($"D1 <= D2: {D1 <= D2}");
            //●	If(D1)
            //DateTime Obj = (DateTime)D1;




        }
    }
}

using oop_5.casting_operator_overloading;
using oop_5.complex;
using System.Drawing;
using oop_5.abstraction;
using oop_5.Static;
namespace oop_5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region  Operators Overloading 
            //Complex c1 = new Complex() { Real = 8, Imag = 5 };
            //Console.Write("c1 = ");
            //Console.WriteLine(c1);
            //Complex c2 = new Complex() { Real = 5, Imag = 2 };
            //Console.Write("c2 = ");
            //Console.WriteLine(c2);
            //Complex c3 = c1 + c2 ;
            //Console.Write("c3 = c1 + c2 = ");
            //Console.WriteLine(c3);
            //Complex c4 = c1 - c2;
            //Console.Write("c4 = c1 - c2 = ");
            //Console.WriteLine(c4);
            //Complex c5 = ++c1 ;
            //Console.Write("c5 = ++c1 = ");
            //Console.WriteLine(c5);
            //Complex c6 = --c2;
            //Console.Write("c6 = --c2 = ");
            //Console.WriteLine(c6);
            //if (c1 > c2) { Console.WriteLine("c1 is greater than c2"); }
            //else if (c1 < c2) { Console.WriteLine("c2 is greater than c1"); }
            #endregion

            #region Casting Operator Overloading
            //Complex c1 = new Complex() { Real = 2, Imag = 4 };
            //int Y = (int)c1;
            //Console.WriteLine(c1);
            //Console.WriteLine(Y); ;
            //string S1 = c1;
            //S1 = (string)c1;    
            //Console.WriteLine(S1);



            //Employee employee = new Employee()
            //{
            //    Id = 10,
            //    FullName = "Nouran Elsayed",
            //    Password = "password",
            //    Email = "nouran@alex.com",
            //    SecurityStamp = Guid.NewGuid()
            //};
            //EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            //employeeViewModel = (EmployeeViewModel)employee;
            //Console.WriteLine(employeeViewModel.FirstName);
            //Console.WriteLine(employeeViewModel.LastName);

            #endregion

            #region abstract

            //Rectangl rectangle = new Rectangl() { Dim01=10 , Dim02=5};
            //decimal RecArea = rectangle.CalcArea();
            //Console.WriteLine($"Area of rectangle = {RecArea}");
            //Console.WriteLine($"perimeter of rectangle = {rectangle.Perimeter}");

            //Console.WriteLine("===========================================");
            //Circle circle = new Circle(30);
            //decimal area = circle.CalcArea();
            //Console.WriteLine($"area of circle: {area}");
            //Console.WriteLine($"perimeter of circle = {circle.Perimeter}");
            #endregion

            //Utility U01 = new Utility(10, 20);
            //Console.WriteLine($"Cm to inch = {Utility.cmToInch(254)}");

            //Utility U02 = new Utility(100, 200);
            //Console.WriteLine($"Cm to inch = {Utility.cmToInch(254)}");
            Console.WriteLine(Utility.CalcCircleArea(5));

        }
    }
    }


using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Globalization;

namespace First_Project
{
    internal class Program
    {
        public static point3D GetPoint( ) {

            Console.Write("Enter X: ");
            string x = Console.ReadLine();
            Console.Write("Enter Y: ");
            string y= Console.ReadLine();
            Console.Write("Enter Z: ");
            string z= Console.ReadLine();
            int X = 0;
            int Y = 0;
            int Z = 0;
            if (x == null)
            { Console.WriteLine("it is not a number"); }
            else
            {
                X = int.Parse(x);
                Console.WriteLine(X);
            }


            if (y == null)
            { Console.WriteLine("it is not a number"); }
            else
            {
                Y = Convert.ToInt32(y);
                Console.WriteLine(Y);
            }

            if (!(int.TryParse(z, out Z)))
            { Console.WriteLine("it is not a number"); }
            else
            {
                Console.WriteLine(Z);
            }
          

            return new point3D(X, Y, Z);
            




            }
        static void Main(string[] args)
        {
            //    First Project:
            //1.Define 3D Point Class and the basic Constructors(use chaining in constructors).

            //2.Override the ToString Function to produce this output:
            //            Point3D P = new Point3D(10, 10, 10);
            //            Console.WriteLine(P.ToString());
            //        Output: “Point Coordinates: (10, 10, 10)”.


            //3.Read from the User the Coordinates for 2 points P1, P2(Check the input using try Pares, Parse, Convert).

            //4.Try to use ==
            //If(P1 == P2)   Does it work properly? =========> /yes it work but not compare point with point but object with object./


            //5.Define an array of points and sort this array based on X &Y coordinates.

            //6.Implement ICloneable interface to be able to clone the object.
            //To implement more than one interface.
            //class Point3D : IComparable, ICloneable



            point3D P = new point3D(10, 10, 10);
            Console.WriteLine(P.ToString());
            point3D P1 =  GetPoint();
            Console.WriteLine(P1.ToString());
            point3D P2= GetPoint();
            Console.WriteLine(P2.ToString());


            point3D[] arr = { P1, P2 };
            Array.Sort(arr);
            foreach (point3D p in arr)
            {
                Console.WriteLine(p);
            }
            }
    }
}

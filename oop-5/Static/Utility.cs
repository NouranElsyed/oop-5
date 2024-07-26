using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5.Static
{
    internal static class Utility
{
        //private static double pi;
        static Utility()
        { //pi = 3.14;
          }
        private const double pi = 3.14;

        public static double PI { get { return pi; } }

        public static double CalcCircleArea(double R) { return PI * R * R; }
    
        public static double cmToInch(double cm) 
        {
            return cm / 2.54;
        }
    }
}

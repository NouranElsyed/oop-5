﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondProject
{
    internal static class Maths
    {


        public static int Add(int num1, int num2)

        {

            return num1 + num2;

        }


        public static int Subtract(int num1, int num2)

        {

            return num1 - num2;

        }
        
        public static int Multiply(int num1, int num2)

        {

            return num1 * num2;

        }

        public static decimal? Divide(int num1, int num2)
        {

            {
                if (num2 > 0)
                {

                    return num1 / num2;
                }

             return null;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondProject
{
    internal class Maths
    {


        public int Add(int num1, int num2)

        {

            return num1 + num2;

        }


        public int Subtract(int num1, int num2)

        {

            return num1 -num2;

        }
        
        public int Multiply(int num1, int num2)

        {

            return num1 * num2;

        }

        public decimal? Divide(int num1, int num2)
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

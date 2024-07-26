using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5.Partial
{
    internal partial class Employee
    {
        public void Print()
        {
            Console.WriteLine("I am Employee");

        }
        public int Test {  get; set; }
        public partial void trry()
        {
            Console.WriteLine("Done");
        }
    }
}

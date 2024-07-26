using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop_5.Sealed
{
    internal class Parent
    {
        private int salary;
        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }
        public virtual void parent()
            {
           Console.WriteLine("I am the Parent");
             }
     }
    class Child:Parent 
        {
        public sealed override int Salary
        {
            get { return base.Salary; }
            set { base.Salary=value<5000? 5000:value; }}
        public sealed override void parent()
        {
   
            Console.WriteLine("I am the Child");
        }
    }
    sealed class GrandChild : Parent
        {
        //public override int Salary {
        //    get { }
        //    set { }
        //}
        }
}
 
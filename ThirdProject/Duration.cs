using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class Duration
    {
        //1.Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
        public int Hours { get; set; }

        public int Minutes { get; set; }

        public int Seconds { get; set; }


        //2.Override All System.Object Members(ToString, Equals, GetHasCode)

        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            else if (Minutes > 0)
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            else return $"Seconds: {Seconds}";
        }


        public new bool Equals(Duration obj)
        {
            if (this.Hours == obj.Hours && this.Minutes == obj.Minutes && this.Seconds == obj.Seconds)
                return true;
            return false;
        }
        public override int GetHashCode()
        {

            return base.GetHashCode();


        }
        // 3.Define All Required Constructors to Produce this output:
        public Duration(int h, int m, int s)
        {
            Hours = h; Minutes = m; Seconds = s;
        }
        public Duration(int t)
        {
            int h = t / 3600;
            int m = (t % 3600) / 60;
            int s = (t % 3600) % 60;

            Hours = h; Minutes = m; Seconds = s;
        }

        //4.Implement All required Operators overloading to enable this Code:

    }
}

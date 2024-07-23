using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public Duration()
        {
            Hours = 0; Minutes = 0; Seconds = 0;
        }
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
        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration()
            {
                Hours = a.Hours + b.Hours,
                Minutes = a.Minutes + b.Minutes,
                Seconds = a.Seconds + b.Seconds

            };

        }
        public static Duration operator +(Duration a, int num)
        {
            Duration b = new Duration(num);
            return new Duration()
            {
                Hours = a.Hours + b.Hours,
                Minutes = a.Minutes + b.Minutes,
                Seconds = a.Seconds + b.Seconds

            };

        }
        public static Duration operator +(int num, Duration a)
        {
            Duration b = new Duration(num);
            return new Duration()
            {
                Hours = a.Hours + b.Hours,
                Minutes = a.Minutes + b.Minutes,
                Seconds = a.Seconds + b.Seconds

            };

        }
        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration()
            {
                Hours = a.Hours - b.Hours,
                Minutes = a.Minutes - b.Minutes,
                Seconds = a.Seconds - b.Seconds

            };
        }
        public static Duration operator ++(Duration c)
        {
            return new Duration()
            {
                Hours = c.Hours,
                Minutes = c.Minutes + 1,
                Seconds = c.Seconds
            };
        }
        public static Duration operator --(Duration c)
        {
            return new Duration()
            {
                Hours = c.Hours,
                Minutes = c.Minutes - 1,
                Seconds = c.Seconds
            };
        }

        public static bool operator >(Duration a, Duration b)
        {
            int num0a = a.Hours * 3600 + a.Minutes * 60 + a.Seconds;
            int numab = b.Hours * 3600 + b.Minutes * 60 + b.Seconds;

            if (num0a > numab)
                return true;

            else return false;
        }

        public static bool operator <(Duration a, Duration b)
        {
            int num0a = a.Hours * 3600 + a.Minutes * 60 + a.Seconds;
            int numab = b.Hours * 3600 + b.Minutes * 60 + b.Seconds;

            if (num0a > numab)
                return true;

            else return false;
        }



        public static bool operator >=(Duration a, Duration b)
        {
            int num0a = a.Hours * 3600 + a.Minutes * 60 + a.Seconds;
            int num0b = b.Hours * 3600 + b.Minutes * 60 + b.Seconds;
            if (num0a == num0b)
                return true;
            if (num0a > num0b)
                return true;

            else return false;
        }
        public static bool operator <=(Duration a, Duration b)
        {
            int num0a = a.Hours * 3600 + a.Minutes * 60 + a.Seconds;
            int num0b = b.Hours * 3600 + b.Minutes * 60 + b.Seconds;
            if (num0a == num0b)
                return true;
            if (num0a < num0b)
                return true;

            else return false;
        }
        public static explicit operator DateTime(Duration c)
        {


            return DateTime.ParseExact($" {c.Hours}:{c.Minutes}:{c.Seconds}", "HH:mm:ss", CultureInfo.InvariantCulture); }

               

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    internal class point3D:IComparable, ICloneable
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int  Z { get; set; }
        public point3D(int x, int y, int z) { X = x; Y = y; Z = z; }    
        public override string ToString()
        {
            return $"Point Coordinates: ({X} ,{Y} ,{Z})"; 
        }

        public int CompareTo(object? obj)
        {
            point3D P= (point3D)obj;
            if (this.X >= P.X && this.Y >= P.Y)
            {
                return 1;
            }
            else if (this.X <= P.X && this.X <=P.Y)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public object Clone()
        {

            return new point3D(this.X, this.Y, this.Z); 

            
        }
    }
}

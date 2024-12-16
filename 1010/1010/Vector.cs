using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1010
{
    public class Vector
    {
        private double x, y;
        public Vector(double ax, double ay) { x = ax; y = ay; }
        public override String ToString()
        {
            return "(" + x.ToString() + ", " + y.ToString() + ")";
        }
        public double R() { return Math.Sqrt(x * x + y * y); }
        public static Vector operator +(Vector a, Vector b)
        {
            Vector c = new Vector(0, 0);
            c.x = a.x + b.x;
            c.y = a.y + b.y;
            return c;
            // var arī skaistāk:
            // return new Vector (a.x + b.x, a.y + b.y);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            Vector c = new Vector(0, 0);
            c.x = a.x - b.x;
            c.y = a.y - b.y;
            return c;
            // var arī skaistāk:
            // return new Vector (a.x - b.x, a.y - b.y);
        }

        public static double operator *(Vector a, Vector b)
        {
            //Vector c = new Vector(0, 0);
            //c.x = a.x * b.x;
            //c.y = a.y + b.y;
            //return c;
            // var arī skaistāk:
            return a.x * b.x + a.y * b.y;
        }

        public static Vector operator ++(Vector a, Vector b)
        {
            if (a.R() > 0) { a.x += a.x / a.R(); a.y += a.y / a.R(); }
            return a;
        }

        public static Vector operator --(Vector a, Vector b)
        {
            if (a.R() > 0) { a.x -= a.x / a.R(); a.y -= a.y / a.R(); }
            return a;
        }

        public static bool operator >(Vector a, Vector b)
        {
            return a.R() > b.R();
        }
        public static bool operator <(Vector a, Vector b)
        {
            return a.R() < b.R();


        }
        public static bool operator ==(Vector a, Vector b)
        {
            return a.x==b.x && a.y == b.y;
        }
        public static bool operator !=(Vector a, Vector b)
        {
            return a.x!=b.x|| a.y!=b.y;


        }// Vector

    }
}

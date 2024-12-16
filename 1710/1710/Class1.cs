using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1710
{
    public class Velocity
    {


        private double sec, m;

            public double Sec
            {
                get { return sec; }
                set { sec = value; }
            }

            public double Min
            {
                get { return sec / 60; }
                set { sec = value * 60; }
            }

            public double H
            {
                get { return sec / 3600.0; }
                set { sec = value * 3600; }
            }

            public double M
            {
                get { return m; }
                set { m = value; }
            }

            public double Km
            {
                get { return m / 1000; }
                set { m = value * 1000; }
            }

            public Velocity()
            {
                sec = 0; m = 0;
            }

        public double MSec()
        {

            return m / sec;

        }


        public double KmH()
        {

            //return (m/1000)/(sec/36000);
            return 3.6*m /sec;

        }

    }
}

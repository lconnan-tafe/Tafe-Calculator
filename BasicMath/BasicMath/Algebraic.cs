using System;
using System.Collections.Generic;
using System.Text;

namespace BasicMath
{
    public class Algebraic
    {
        public static double Sqrt(double a)
        {
            return (Math.Pow(a, 0.5));
        }

        public static double Curt(double a)
        {
            return (Math.Pow(a, 0.33333333));
        }

        public static double Inv(double a)
        {
            return -a;
        }
    }
}

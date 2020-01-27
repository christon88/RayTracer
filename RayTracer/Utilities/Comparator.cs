using System;
using System.Collections.Generic;
using System.Text;

namespace RayTracer.Features
{
    public static class Comparator
    {
        public static bool LooseEq(this double a, double b)
        {
            var epsilon = 0.000001;

            return Math.Abs(a - b) < epsilon ;
        }
        public static bool LooseEq(this float a, float b)
        {
            var epsilon = 0.000001;

            return Math.Abs(a - b) < epsilon ;
        }
        public static bool LooseEq(this float a, double b)
        {
            var epsilon = 0.000001;

            return Math.Abs(a - b) < epsilon ;
        }
    }
}

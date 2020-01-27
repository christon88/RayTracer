using System;

namespace RayTracer.Features
{
    public class Color : Tuple
    {
        public Color(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        private new double X;
        private new double Y;
        private new double Z;
        public double Red { get => X; }
        public double Green { get => Y; }
        public double Blue { get => Z; }
        private int PPM(double value)
        {
            return Convert.ToInt32(Math.Max(0, Math.Min(255, value * 255)));
        }
        public string RGBValue() => $"{PPM(Red)} {PPM(Green)} {PPM(Blue)}";
    }
}

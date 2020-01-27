using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace RayTracer.Features
{
    public class Tuple
    {
        public Tuple()
        {

        }
        public Tuple(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Tuple(double x, double y, double z, double w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        [Flags]
        public enum TupleType
        {
            point = 1,
            vector = 0
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double W { get; set; }
        public TupleType Type { get { return (TupleType)W; } }
        public bool Equals(Tuple otherTuple) =>
                X.LooseEq(otherTuple.X) &&
                Y.LooseEq(otherTuple.Y) &&
                Z.LooseEq(otherTuple.Z) &&
                W.LooseEq(otherTuple.W) &&
                Type == otherTuple.Type
                ;


        public static Tuple operator +(Tuple a, Tuple b)
            => new Tuple(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
        public static Tuple operator -(Tuple a, Tuple b)
            => new Tuple(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
        public static Tuple operator -(Tuple a)
            => new Tuple(-a.X, -a.Y, -a.Z, -a.W);
        public static Tuple operator *(Tuple a, double b)
            => new Tuple(a.X * b, a.Y * b, a.Z * b);
        public static Tuple operator /(Tuple a, double b)
            => new Tuple(a.X / b, a.Y / b, a.Z / b);

    }
}

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace RayTracer.Features
{
    public static class TupleFactory
    {
        public static Vector4 Point(float x, float y, float z) => new Vector4(x, y, z, 1);
        public static Vector4 Point(double x, double y, double z) => new Vector4(Convert.ToSingle(x), Convert.ToSingle(y), Convert.ToSingle(z), 1);
        public static Vector4 Vector(float x, float y, float z) => new Vector4(x, y, z, 0);
        public static Vector4 Vector(double x, double y, double z) => new Vector4(Convert.ToSingle(x), Convert.ToSingle(y), Convert.ToSingle(z), 0);
        public static Vector4 Tuple(float x, float y, float z, float w) => new Vector4(x, y, z, w);
        public static Vector4 Tuple(double x, double y, double z, double w) => new Vector4(Convert.ToSingle(x), Convert.ToSingle(y), Convert.ToSingle(z), Convert.ToSingle(w));

    }
}

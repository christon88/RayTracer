using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace RayTracer.Features
{
    public static class Vector4Extensions
    {
        public static Vector4 Cross(this Vector4 vectorA, Vector4 vectorB)
        {
            return new Vector4(Convert.ToSingle(vectorA.Y * vectorB.Z) - Convert.ToSingle(vectorA.Z * vectorB.Y),
                                                    Convert.ToSingle(vectorA.Z * vectorB.X) - Convert.ToSingle(vectorA.X * vectorB.Z),
                                                    Convert.ToSingle(vectorA.X * vectorB.Y) - Convert.ToSingle(vectorA.Y * vectorB.X), 0);
        }

    }
}

using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
using RayTracer.Features.Shapes;

namespace RayTracer.Features
{
    public class Ray
    {
        public Vector4 Origin { get; set; }
        public Vector4 Direction { get; set; }
        public Ray (Vector4 origin, Vector4 direction)
        {
            Origin = origin;
            Direction = direction;
        }
        public Vector4 Position(float time) => Origin + Direction * time;
        public double[] Intersects(Shape shape)
        {
            var result = new double[2];
            return result;
        }
    }
}

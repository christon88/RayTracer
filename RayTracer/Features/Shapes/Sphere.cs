using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static RayTracer.Features.TupleFactory;

namespace RayTracer.Features.Shapes
{
    public class Sphere : Shape
    {
        public double Radius { get; set; }
        public Vector4 Origin { get; set; }
        public Sphere()
        {
            Radius = 1;
            Origin = Point(0, 0, 0);
        }
        public double[] Intersects(Ray ray)
        {
            var sphere_to_ray = ray.Origin - Point(0, 0, 0);
            var a = Vector4.Dot(ray.Direction, ray.Direction);
            var b = 2 * Vector4.Dot(ray.Direction, sphere_to_ray);
            var c = Vector4.Dot(sphere_to_ray, sphere_to_ray);
            var discriminant = b * b - 4 * a * c;

            if (discriminant)


        }
    }
}

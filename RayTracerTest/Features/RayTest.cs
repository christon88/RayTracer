using Microsoft.VisualStudio.TestTools.UnitTesting;
using RayTracer.Features;
using RayTracer.Features.Shapes;
using System.Numerics;
using static RayTracer.Features.TupleFactory;

namespace RayTracerTest
{
    [TestClass]
    public class RayTest
    {
        [TestMethod]
        public void CanBeCreated()
        {
            // --Arrange
            var origin = Point(1, 2, 3);
            var direction = Vector(4, 5, 6);
            // --Act
            var r = new Ray(origin, direction);
            // --Assert
            Assert.AreEqual(new Vector4(1, 2, 3, 0), r.Origin);
            Assert.AreEqual(new Vector4(4, 5, 6, 1), r.Direction);
        }
        [TestMethod]
        public void CanComputePointFromDistance()
        {
            // --Arrange
            var origin = new Vector4(2, 3, 4, 1);
            var direction = new Vector4(1, 0, 0, 0);
            // --Act
            var ray = new Ray(origin, direction);
            var p1 = ray.Position(0);
            var p2 = ray.Position(1);
            var p3 = ray.Position(-1);
            var p4 = ray.Position(2.5f);
            // --Assert
            Assert.AreEqual(new Vector4(2, 3, 4, 1), p1);
            Assert.AreEqual(new Vector4(3, 3, 4, 1), p2);
            Assert.AreEqual(new Vector4(1, 3, 4, 1), p3);
            Assert.AreEqual(new Vector4(4.5f, 3, 4, 1), p4);
        }
        [TestMethod]
        public void CanIntersectSphere()
        {
            // --Arrange
            var ray = new Ray(Point(0, 0, -5), Vector(0, 0, 1));
            var sphere = new Sphere();
            // --Act
            var intersects = sphere.Intersects(ray);

            // --Assert
            Assert.AreEqual(2, intersects.Length);
            Assert.IsTrue(4.0.LooseEq(intersects[0]));
            Assert.IsTrue(6.0.LooseEq(intersects[1]));
        }

        [TestMethod]
        public void CanIntersectSphereOnTangent()
        {
            // --Arrange
            var ray = new Ray(Point(0, 1, -5), Vector(0, 0, 1));
            var sphere = new Sphere();
            // --Act
            var intersects = sphere.Intersects(ray);

            // --Assert
            Assert.AreEqual(2, intersects.Length);
            Assert.IsTrue(5.0.LooseEq(intersects[0]));
            Assert.IsTrue(5.0.LooseEq(intersects[1]));
        }
        [TestMethod]
        public void ReturnsZeroOnMizz()
        {
            // --Arrange
            var ray = new Ray(Point(0, 2, -5), Vector(0, 0, 1));
            var sphere = new Sphere();
            // --Act
            var intersects = sphere.Intersects(ray);

            // --Assert
            Assert.AreEqual(0, intersects.Length);
        }
        [TestMethod]
        public void OriginatesInsideSphere()
        {
            // --Arrange
            var ray = new Ray(Point(0, 0, 0), Vector(0, 0, 1));
            var sphere = new Sphere();
            // --Act
            var intersects = sphere.Intersects(ray);

            // --Assert
            Assert.AreEqual(2, intersects.Length);
            Assert.IsTrue((-1.0).LooseEq(intersects[0]));
            Assert.IsTrue(1.0.LooseEq(intersects[1]));
        }
        [TestMethod]
        public void OriginatesAfterSphere()
        {
            // --Arrange
            var ray = new Ray(Point(0, 0, 5), Vector(0, 0, 1));
            var sphere = new Sphere();
            // --Act
            var intersects = sphere.Intersects(ray);

            // --Assert
            Assert.AreEqual(2, intersects.Length);
            Assert.IsTrue((-6.0).LooseEq(intersects[0]));
            Assert.IsTrue((-4.0).LooseEq(intersects[1]));
        }


    }
}

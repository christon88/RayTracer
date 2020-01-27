using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RayTracer.Features;
using static RayTracer.Features.TupleFactory;

namespace RayTracerTest
{
    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void VectorCanBeNegated()
        {
            // --Arrange
            var a = Vector(3, 2, 1);
            var expected = Vector(-3, -2, -1);
            // --Act
            var actual = -a;
            // --Assert
            Assert.IsTrue(actual.Equals(expected));
        }
        [TestMethod]
        public void VectorCanBeMultiplied()
        {
            // --Arrange
            var a = Vector(3, -2, 1);
            // --Act
            var actual = a * 2.5f;
            var expected = Vector(7.5, -5, 2.5);
            // --Assert
            Assert.IsTrue(actual.Equals(expected));
        }
        [TestMethod]
        public void VectorCanBeDivided()
        {
            // --Arrange
            var a = Vector(7.5, -5, 2.5);
            var expected = Vector(3, -2, 1);
            // --Act
            var actual = a / 2.5f;
            // --Assert
            Assert.IsTrue(actual.Equals(expected));
        }

        [TestMethod]
        public void VectorsHaveCorrectMagnitude()
        {
            // --Arrange
            var a = Vector(1, 0, 0);
            var b = Vector(0, 1, 0);
            var c = Vector(0, 0, 1);
            var d = Vector(1, 2, 3);
            var e = Vector(-1, -2, -3);
            // --Act
            // --Assert
            Assert.AreEqual(a.Length(), 1);
            Assert.AreEqual(b.Length(), 1);
            Assert.AreEqual(c.Length(), 1);
            Assert.IsTrue(d.Length().LooseEq(System.Math.Sqrt(14)));
            Assert.IsTrue(e.Length().LooseEq(System.Math.Sqrt(14)));
        }

        [TestMethod]
        public void VectorHasDotProduct()
        {
            // --Arrange
            var a = Vector(1, 2, 3);
            var b = Vector(2, 3, 4);
            var expected = 20;
            // --Act
            var actual = Vector4.Dot(a, b);
            // --Assert
            Assert.IsTrue(actual.Equals(expected));
        }
        [TestMethod]
        public void VectorHasCrossProduct()
        {
            // --Arrange
            var a = Vector(1, 2, 3);
            var b = Vector(2, 3, 4);
            var expected_a = Vector(-1, 2, -1);
            var expected_b = Vector(1, -2, 1);
            // --Act
            var actual_a = a.Cross(b);
            var actual_b = b.Cross(a);
            // --Assert
            Assert.IsTrue(actual_a.Equals(expected_a));
            Assert.IsTrue(actual_b.Equals(expected_b));
        }


    }
}

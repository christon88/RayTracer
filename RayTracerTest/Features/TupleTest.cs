using Microsoft.VisualStudio.TestTools.UnitTesting;
using RayTracer.Features;
using static RayTracer.Features.TupleFactory;

namespace RayTracerTest
{
    [TestClass]
    public class TupleTest
    {
        [TestMethod]
        public void TupleWithW1IsAPoint()
        {
            // --Arrange
            var a = Tuple(4.3, -4.2, 3.1, 1);
            // --Act
            // --Assert
            Assert.AreEqual(a.X, 4.3f);
            Assert.AreEqual(a.Y, -4.2f);
            Assert.AreEqual(a.Z, 3.1f);
            Assert.AreEqual(a.W, 1f);
        }

        [TestMethod]
        public void TupleWithW0IsAVector()
        {
            // --Arrange
            var a = Tuple(4.3, -4.2, 3.1, 0);
            // --Act
            // --Assert
            Assert.AreEqual(a.X, 4.3f);
            Assert.AreEqual(a.Y, -4.2f);
            Assert.AreEqual(a.Z, 3.1f);
            Assert.AreEqual(a.W, 0f);
        }
        
        [TestMethod]
        public void PointCreatesTupleWithW1()
        {
            // --Arrange
            var p = Point(4.3, -4.2, 3.1);
            var t = Tuple(4.3, -4.2, 3.1, 1);
            // --Act
            // --Assert
            Assert.IsTrue(p.Equals(t));
        }

        [TestMethod]
        public void VectorCreatesTupleWithW0()
        {
            // --Arrange
            var v = Vector(4.3, -4.2, 3.1);
            // --Act
            // --Assert
            Assert.IsTrue(v.Equals(Tuple(4.3, -4.2, 3.1, 0)));
        }
        [TestMethod]
        public void LooseEqualsValid()
        {
            // --Arrange
            var a = 1.0000000001;
            // --Act
            // --Assert
            Assert.IsTrue(a.LooseEq(1));
        }
        
        [TestMethod]
        public void TuplesCanAdd()
        {
            // --Arrange
            var a = Tuple(2, 3, -1, 0);
            var b = Tuple(1, 0, 2, 1);
            // --Act
            var actual = a + b;
            var expected = Tuple(3, 3, 1, 1);
            // --Assert
            Assert.IsTrue(actual.Equals(expected));
        }
        [TestMethod]
        public void TwoPointsCanSubtract()
        {
            // --Arrange
            var a = Point(2, 3, -1);
            var b = Point(1, 0, 2);
            // --Act
            var actual = a - b;
            var expected = Vector(1, 3, -3);
            // --Assert
            Assert.IsTrue(actual.Equals(expected));
        }
        public void PointAndVectorCanSubtract()
        {
            // --Arrange
            var a = Point(3, 2, 1);
            var b = Vector(5, 6, 7);
            // --Act
            var actual = a - b;
            var expected = Point(-2, -4, -6);
            // --Assert
            Assert.IsTrue(actual.Equals(expected));
        }
        [TestMethod]
        public void TwoVectorsCanSubtract()
        {
            // --Arrange
            var a = Vector(3, 2, 1);
            var b = Vector(5, 6, 7);
            // --Act
            var actual = a - b;
            var expected = Vector(-2, -4, -6);
            // --Assert
            Assert.IsTrue(actual.Equals(expected));
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using RayTracer.Features;

namespace RayTracerTest
{
    [TestClass]
    public class ColorTest
    {
        [TestMethod]
        public void ColorsAreRGBTuples()
        {
            // --Arrange
            var c = new Color(3, 2, 1);       
            // --Act
            
            // --Assert
            Assert.AreEqual(c.Red, 3);
            Assert.AreEqual(c.Green, 2);
            Assert.AreEqual(c.Blue, 1);
        }
        [TestMethod]
        public void TwoColorsCanSubtract()
        {
            // --Arrange
            var a = new Color(2, 3, -1);
            var b = new Color(1, 0, 2);
            // --Act
            var actual = a - b;
            var expected = new Color(1, 3, -3);
            // --Assert
            Assert.IsTrue(actual.Equals(expected));
        }
        [TestMethod]
        public void ColorCanBeMultiplied()
        {
            // --Arrange
            var a = new Color(3, -2, 1);
            // --Act
            var actual = a * 2.5;
            var expected = new Color(7.5, -5, 2.5);
            // --Assert
            Assert.IsTrue(actual.Equals(expected));
        }
        [TestMethod]
        public void ColorCanBeDivided()
        {
            // --Arrange
            var a = new Color(7.5, -5, 2.5);
            var expected = new Color(3, -2, 1);
            // --Act
            var actual = a / 2.5;
            // --Assert
            Assert.IsTrue(actual.Equals(expected));
        }



    }
}

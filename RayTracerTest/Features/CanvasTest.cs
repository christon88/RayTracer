using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RayTracer.Features;

namespace RayTracerTest
{
    [TestClass]
    public class CanvasTest
    {
        [TestMethod]
        public void CanCreateCanvas()
        {
            // --Arrange
            var c = new Canvas(10, 5);
            // --Act
            // --Assert
            Assert.AreEqual(c.Width, 10);
            Assert.AreEqual(c.Height, 5);
            foreach (var row in c.Pixels)
            {
                foreach (var pixel in row)
                {
                    Assert.IsTrue(new Color(0, 0, 0).Equals(pixel));
                }
            }
        }
        [TestMethod]
        public void CanWritePixel()
        {
            // --Arrange
            var c = new Canvas(10, 10);
            var red = new Color(1, 0, 0);
            // --Act
            c.Pixels[2][3] = red;
            // --Assert
            Assert.IsTrue(c.Pixels[2][3].Equals(new Color(1, 0, 0)));
            Assert.IsTrue(c.Pixels[2][2].Equals(new Color(0, 0, 0)));

        }
        [TestMethod]
        public void CanConstructPPMHeader()
        {
            // --Arrange
            var c = new Canvas(10, 8);
            var line1Expected = "P3";
            var line2Expected = "10 8";
            var line3Expected = "255";
            // --Act
            var PPM = c.GetPPM();
            var line1Actual = PPM.Split(Environment.NewLine)[0];
            var line2Actual = PPM.Split(Environment.NewLine)[1];
            var line3Actual = PPM.Split(Environment.NewLine)[2];
            // --Assert
            Assert.AreEqual(line1Expected, line1Actual);
            Assert.AreEqual(line2Expected, line2Actual);
            Assert.AreEqual(line3Expected, line3Actual);

        }
        [TestMethod]
        public void CanConstructPPMPixelData()
        {
            // --Arrange
            var canvas = new Canvas(3, 3);
            var c1 = new Color(1.5, 0, 0);
            var c2 = new Color(0, 0.5, 0);
            var c3 = new Color(-0.5, 0, 1);
            canvas.Pixels[0][0] = c1;
            canvas.Pixels[1][1] = c2;
            canvas.Pixels[2][2] = c3;
            var line4Expected = "255 0 0 0 0 0 0 0 0";
            var line5Expected = "0 0 0 0 128 0 0 0 0";
            var line6Expected = "0 0 0 0 0 0 0 0 255";
            // --Act
            var PPM = canvas.GetPPM();
            var line4Actual = PPM.Split(Environment.NewLine)[3];
            var line5Actual = PPM.Split(Environment.NewLine)[4];
            var line6Actual = PPM.Split(Environment.NewLine)[5];
            // --Assert
            Assert.AreEqual(line4Expected, line4Actual);
            Assert.AreEqual(line5Expected, line5Actual);
            Assert.AreEqual(line6Expected, line6Actual);
        }


    }
}

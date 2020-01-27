using RayTracer.Features;
using RayTracer.Utilities;
using System;

namespace Controller
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas(3, 3);
            var c1 = new Color(1.5, 0, 0);
            var c2 = new Color(0, 0.8, 0.5);
            var c3 = new Color(-0.5, 0, 1);
            canvas.Pixels[0][0] = c1;
            canvas.Pixels[1][1] = c2;
            canvas.Pixels[2][2] = c3;
            var PPM = canvas.GetPPM();

            var path = "c:\\temp\\MyTest.ppm";


            var writer = new FileWriter();
            writer.WriteFile(path, PPM);

        }
    }
}

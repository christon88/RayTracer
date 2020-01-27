using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace RayTracer.Features
{
    public class Canvas
    {
        public Canvas()
        {

        }
        public Canvas(int width, int height)
        {
            Width = width;
            Height = height;
            Pixels = new Color[Width][];
            for (var i = 0; i < Width; i++)
            {
                var _row = new Color[Height];
                Array.Fill(_row, new Color(0, 0, 0));
                Pixels[i] = _row;
            }

        }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color[][] Pixels { get; set; }
        public string WritePPMHeader()
        {
            return $"P3{Environment.NewLine}{$"{Width} {Height}"}{Environment.NewLine}255";
        }

        public string WritePPMLine(Color[] row)
        {
            return string.Join(" ", row.Select(color => color.RGBValue()));
        }
        public string WritePPMPixels(Color[][] pixels)
        {
            return string.Join(
                Environment.NewLine,
                pixels.Select(row => WritePPMLine(row)));
                    
        }
        public string GetPPM() => 
            WritePPMHeader() 
            + Environment.NewLine 
            + WritePPMPixels(Pixels) 
            + Environment.NewLine;

    }
}

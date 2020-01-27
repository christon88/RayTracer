using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace RayTracer.Utilities
{
    public class FileWriter
    {
        public string Path { get; set; }
        public bool WriteFile(string path, string content)
        {
            File.WriteAllText(path, content);
            return true;
        }
    }
}

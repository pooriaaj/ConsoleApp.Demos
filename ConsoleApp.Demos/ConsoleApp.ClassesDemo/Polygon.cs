using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.ClassesDemo
{
    public abstract class Polygon
    {
        public double Width { get; set; }
        public abstract double Area();
    }
}
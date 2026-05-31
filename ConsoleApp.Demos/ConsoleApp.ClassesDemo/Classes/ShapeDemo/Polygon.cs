using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public abstract class Polygon
    {
        public double Width { get; set; }
        public abstract double Area();
    }
}
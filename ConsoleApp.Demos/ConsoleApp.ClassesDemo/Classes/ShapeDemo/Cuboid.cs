using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public class Cuboid : Polygon, I2DShape, I3DShape
    {
        public Cuboid(double width, double length, double height)
        {
            Width = width;
            Length = length;
            Height = height;
        }
        public double Length { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return 2 * (Width * Length) + (Height * Length) + (Height * Width);
        }

        public double Perimeter()
        {
            return 4 * (Length + Height + Width);
        }

        public double Volume()
        {
            return (Length * Width * Height);
        }
    }
}
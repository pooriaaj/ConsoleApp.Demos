using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public double Length { get; set; }
        public override double Area()
        {
            return Width * Length;
        }

        public double Perimeter()
        {
            return (2 * Length) + (2 * Width);
        }
    }
}

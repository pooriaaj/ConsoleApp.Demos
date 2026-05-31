namespace ConsoleApp.ClassesDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public Rectangle(double width, double length)
        {
            width = Width;
            length = Length;
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

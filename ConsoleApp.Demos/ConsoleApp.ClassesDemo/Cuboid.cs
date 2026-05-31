namespace ConsoleApp.ClassesDemo
{
    public class Cuboid : Polygon, I2DShape, I3DShape
    {
        public Cuboid(double width, double length, double height)
        {
            width = Width;
            length = Length;
            height = Height;
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
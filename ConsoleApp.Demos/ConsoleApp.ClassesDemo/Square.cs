namespace ConsoleApp.ClassesDemo
{
    public class Square : Polygon
    {
        public Square(double width)
        {
            width = Width;
        }
        public override double Area()
        {
            // Math.Pow(Width, 2);
            return Width * Width;
        }
    }
}

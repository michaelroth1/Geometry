namespace Geometry
{
    public class Rectangle : Shape
    {
        public Rectangle(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public override double GetArea()
        {
            return X * Y;
        }
    }
}
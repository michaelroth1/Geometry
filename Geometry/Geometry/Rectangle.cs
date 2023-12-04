﻿namespace Geometry
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
namespace ShapeTask
{
    internal class Rectangle : IShape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;

            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public double GetHeight()
        {
            return Height;
        }

        public double GetPerimeter()
        {
            return Width * 2 + Height * 2;
        }

        public double GetWidth()
        {
            return Width;
        }
    }
}

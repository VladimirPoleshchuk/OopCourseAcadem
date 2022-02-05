namespace ShapeTask
{
    internal class Square : IShape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public Square(double height)
        {
            Height = height;

            Width = height;
        }

        public double GetWidth()
        {
            return Width;
        }

        public double GetHeight()
        {
            return Height;
        }

        public double GetArea()
        {
            return Height * Width;
        }

        public double GetPerimeter()
        {
            return Height * 2 + Width * 2;
        }
    }
}
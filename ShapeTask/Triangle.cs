namespace ShapeTask
{
    internal class Triangle : IShape
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double X3 { get; set; }
        public double Y1 { get; set; }
        public double Y2 { get; set; }
        public double Y3 { get; set; }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            X1 = x1;
            X2 = x2;
            X3 = x3;
            Y1 = y1;
            Y2 = y2;
            Y3 = y3;
        }

        public double GetArea()
        {
            return Math.Abs((X2 - X1) * (Y3 - Y1) - (X3 - X1) * (Y2 - Y1)) / 2;
        }

        public double GetHeight()
        {
            double maxY = GetMaxNumber(Y1, Y2, Y3);

            double minY = GetMinNumber(Y1, Y2, Y3);

            return maxY - minY;
        }

        public double GetPerimeter()
        {
            return Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2)) +
                   Math.Sqrt((X2 - X3) * (X2 - X3) + (Y2 - Y3) * (Y2 - Y3)) +
                   Math.Sqrt((X3 - X1) * (X3 - X1) + (Y3 - Y1) * (Y3 - Y1));
        }

        public double GetWidth()
        {
            double maxX = GetMaxNumber(X1, X2, X3);

            double minX = GetMinNumber(X1, X2, X3);

            return maxX - minX;
        }

        private static double GetMaxNumber(double number1, double number2, double number3)
        {
            double maxNumber;

            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    maxNumber = number1;
                }
                else
                {
                    maxNumber = number3;
                }
            }
            else
            {
                if (number2 > number3)
                {
                    maxNumber = number2;
                }
                else
                {
                    maxNumber = number3;
                }
            }

            return maxNumber;
        }

        private static double GetMinNumber(double number1, double number2, double number3)
        {
            double minNumber;

            if (number1 < number2)
            {
                if (number1 < number3)
                {
                    minNumber = number1;
                }
                else
                {
                    minNumber = number3;
                }
            }
            else
            {
                if (number2 < number3)
                {
                    minNumber = number2;
                }
                else
                {
                    minNumber = number3;
                }
            }

            return minNumber;
        }
    }
}
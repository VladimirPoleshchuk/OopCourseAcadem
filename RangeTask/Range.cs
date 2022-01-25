using System;

namespace RangeTask
{
    public class Range
    {
         public double From { get; set; }

        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            return (number - From >0 && number - To <0);
        }
    }
}
namespace RangeTask
{
    public class Range
    {
        public double From { get; set; }

        public double To { get; set; }

        public Range Range1 { get; set; }

        public Range Range2 { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public Range(Range range1, Range range2)
        {
            Range1 = range1;
            Range2 = range2;
        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            return (number - From > 0 && number - To < 0);
        }

        public Range GetIntersection()
        {
            if (Range1.To < Range2.From || Range2.To < Range1.From)
            {
                return null;
            }

            if (Range1.From < Range2.From && Range1.To > Range2.To)
            {
                return Range2;
            }

            if (Range1.From > Range2.From && Range1.To < Range2.To)
            {
                return Range1;
            }

            if (Range1.From < Range2.From && Range1.To > Range2.From)
            {
                return new Range(Range2.From, Range1.To);
            }

            if (Range2.From < Range1.From && Range1.From < Range2.To)
            {
                return new Range(Range1.From, Range2.To);
            }

            return Range1;
        }

        public Range[] GetUnion()
        {
            Range[] arrayRanges = new Range[2];

            if (Range1.From < Range2.From && Range2.From <= Range1.To)
            {
                arrayRanges[0] = new Range(Range1.From, Range2.To);

                return arrayRanges;
            }

            if (Range2.From < Range1.From && Range1.From <= Range2.To)
            {
                arrayRanges[0] = new Range(Range2.From, Range1.To);

                return arrayRanges;
            }

            if (Range1.From <= Range2.From && Range2.To <= Range1.To)
            {
                arrayRanges[0] = Range1;

                return arrayRanges;
            }

            if (Range2.From <= Range1.From && Range1.To <= Range2.To)
            {
                arrayRanges[0] = Range1;

                return arrayRanges;
            }

            arrayRanges[0] = Range1;
            arrayRanges[1] = Range2;

            return arrayRanges;
        }

        public Range GetDifference()
        {
            if (Range1.From < Range2.From && Range2.From < Range1.To)
            {
                return new Range(Range1.From, Range2.From);
            }

            if (Range2.From < Range1.From && Range1.From < Range2.To)
            {
                return new Range(Range2.To, Range1.To);
            }

            if (Range1.From < Range2.From && Range2.To < Range1.To)
            {
                Range[] arrayRanges = { new Range(Range1.From, Range2.From), new Range(Range2.To, Range1.To) };

                //   return arrayRanges;
            }

            if (Range2.From < Range1.From && Range1.To < Range2.To)
            {
                Range[] arrayRanges = { new Range(Range2.From, Range1.From), new Range(Range1.To, Range2.To) };

                //   return arrayRanges;
            }

            return null;
        }

        public override string ToString()
        {
            return String.Format("Интервал-пересечения двух интервалов: ({0:f2}; {1:f2})", From, To);
        }
    }
}
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
            return number >= From && number <= To;
        }

        public Range GetIntersection(double from, double to)
        {
            double minFrom = Math.Min(From, from);

            double minTo = Math.Min(To, to);

            double maxFrom = Math.Max(From, from);

            if (minFrom < maxFrom && minTo <= maxFrom)
            {
                return null;
            }

            if (minFrom < maxFrom && maxFrom < minTo)
            {
                return new Range(maxFrom, minTo);
            }

            return new Range(maxFrom, minTo);
        }

        public Range[] GetUnion(double from, double to)
        {
            double minFrom = Math.Min(From, from);

            double minTo = Math.Min(To, to);

            double maxFrom = Math.Max(From, from);

            double maxTo = Math.Max(To, to);

            if (minFrom <= maxFrom && maxFrom <= minTo)
            {
                return new Range[] { new Range(minFrom, maxTo) };
            }

            if (minFrom < maxFrom && minTo < maxFrom)
            {
                return new Range[] { new Range(minFrom, minTo), new Range(maxFrom, maxTo) };
            }

            return new Range[] { new Range(minFrom, maxTo) };
        }

        public Range[] GetDifference(double from, double to)
        {
            if (From < from && from < To && To < to)
            {
                return new Range[] { new Range(From, from) };
            }

            if (From < from && To < from)
            {
                return new Range[0];
            }

            return new Range[] { new Range(From, from), new Range(to, To) };
        }

        public override string ToString()
        {
            return $"({From:f2}; {To:f2})";
        }
    }
}
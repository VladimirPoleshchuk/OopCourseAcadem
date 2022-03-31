namespace VectorTask
{
    public abstract class Segment
    {
        public abstract int GetSize();
               
        public abstract Segment GetSum(Segment vector);

        public abstract Segment GetDifference(Segment vector);

        public abstract Segment GetScalar(double number);

        public abstract Segment GetReverse();

        public abstract int GetLength(Segment vector);
    }
}

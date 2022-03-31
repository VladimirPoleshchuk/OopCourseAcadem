
namespace VectorTask
{
   partial class Vector : Segment
    {
        public int Size { get; set; }

        public double[] VectorNumbers { get; set; }

        public Vector(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("size");
            }

            Size = size;
            VectorNumbers = new double[size];
        }

        public Vector(double[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException();
            }

            Size = numbers.Length;

            VectorNumbers = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; ++i)
            {
                VectorNumbers[i] = numbers[i];
            }
        }

        public Vector(int size, double[] numbers)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("size");
            }

            if (numbers == null)
            {
                throw new ArgumentNullException();
            }

            Size = size;

            VectorNumbers = new double[size];

            for (int i = 0; i < numbers.Length; ++i)
            {
                VectorNumbers[i] = numbers[i];
            }
        }

        public Vector(Vector vector)
        {
            Size = vector.Size;

            VectorNumbers = new double[vector.Size];

            for (int i = 0; i < VectorNumbers.Length; ++i)
            {
                VectorNumbers[i] = vector.VectorNumbers[i];
            }
        }
    }
}

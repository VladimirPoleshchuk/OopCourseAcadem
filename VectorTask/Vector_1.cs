
namespace VectorTask
{
    partial class Vector : Segment
    {
        public override int GetSize()
        {
            return Size;
        }

        public override string ToString()
        {
            return "{" + String.Join(", ", VectorNumbers) + "}";
        }

        public override Vector GetSum(Segment vector)
        {
            Vector vector1;

            Vector vector2 = vector as Vector;

            if (Size < vector2.Size)
            {
                vector1 = new Vector(vector2.VectorNumbers);

                for (int i = 0; i < Size; i++)
                {
                    vector1.VectorNumbers[i] += VectorNumbers[i];
                }
            }
            else
            {
                vector1 = new Vector(VectorNumbers);

                for (int i = 0; i < vector2.Size; i++)
                {
                    vector1.VectorNumbers[i] += vector2.VectorNumbers[i];
                }
            }

            return vector1;
        }

        public override Vector GetDifference(Segment vector)
        {
            Vector vector1;

            Vector vector2 = vector as Vector;

            if (Size < vector2.Size)
            {
                vector1 = new Vector(vector2.Size, VectorNumbers);

                for (int i = 0; i <vector2.Size; i++)
                {
                    vector1.VectorNumbers[i] -= vector2.VectorNumbers[i];
                }
            }
            else
            {
                vector1 = new Vector(VectorNumbers);

                for (int i = 0; i < vector2.Size; i++)
                {
                    vector1.VectorNumbers[i] -= vector2.VectorNumbers[i];
                }
            }

            return vector1;
        }

        public override Vector GetScalar(double number)
        {
            Vector vector1 = new(VectorNumbers);

            for (int i = 0; i < vector1.Size; i++)
            {
                if (vector1.VectorNumbers[i] == 0)
                {
                    continue;
                }

                vector1.VectorNumbers[i] *= number;
            }

            return vector1;
        }

        public override Vector GetReverse()
        {
            Vector vector2 = new(VectorNumbers);

            for (int i = 0; i < vector2.Size; i++)
            {
                if (vector2.VectorNumbers[i] == 0)
                {
                    continue;
                }

                vector2.VectorNumbers[i] *= (-1);
            }

            return vector2;
        }

        public override int GetLength(Segment vector)
        {
            return vector.GetSize();
        }

        public double GetValue(int index)
        {
            if (index > Size)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            return VectorNumbers[index];
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            Vector vector = obj as Vector;

            if (vector.Size == Size)
            {
                for (int i = 0; i < Size; i++)
                {
                    if (vector.VectorNumbers[i] != VectorNumbers[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int prime = 27;
            int hash = 1;

            hash = prime * hash + Size;

            for (int i = 0; i < Size; i++)
            {
                hash += prime * hash + VectorNumbers[i].GetHashCode();
            }

            return hash;
        }

        public static Vector GetSum(Vector vector1, Vector vector2)
        {
            Vector vector;

            if (vector1.Size < vector2.Size)
            {
                vector = new Vector(vector2.VectorNumbers);

                for (int i = 0; i < vector1.Size; i++)
                {
                    vector.VectorNumbers[i] += vector1.VectorNumbers[i];
                }
            }
            else
            {
                vector = new Vector(vector1.VectorNumbers);

                for (int i = 0; i < vector2.Size; i++)
                {
                    vector.VectorNumbers[i] += vector2.VectorNumbers[i];
                }
            }

            return vector;
        }

        public static Vector GetDifference(Vector vector1, Vector vector2)
        {
            Vector vector;

            if (vector1.Size < vector2.Size)
            {
                vector = new Vector(vector2.Size, vector1.VectorNumbers);
            }
            else
            {
                vector = new Vector(vector1.VectorNumbers);                
            }
            
            for (int i = 0; i < vector2.Size; i++)
                {
                    vector.VectorNumbers[i] -= vector2.VectorNumbers[i];
                }

            return vector;
        }

        public static double GetScalarMultiply(Vector vector1, Vector vector2)
        {
            Vector vector;

            double scalar = 0; 

            if (vector1.Size < vector2.Size)
            {
                vector = new Vector(vector2.VectorNumbers);

                for (int i = 0; i < vector1.Size; i++)
                {
                    vector.VectorNumbers[i] *= vector1.VectorNumbers[i];

                    scalar += vector.VectorNumbers[i];
                }
            }
            else
            {
                vector = new Vector(vector1.VectorNumbers);

                for (int i = 0; i < vector2.Size; i++)
                {
                    vector.VectorNumbers[i] *= vector2.VectorNumbers[i];

                    scalar += vector.VectorNumbers[i];
                }
            }

            return scalar;
        }
    }
}
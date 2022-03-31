namespace VectorTask
{
    class VectorMain
    {
        public static void Main()
        {
            int n = 8;

            double scalar = 2.5;

            double[] numbersArray1 = { 1.5, 6, 2.5, 10.9 };

            double[] numbersArray2 = { 2, 5, 9, 0, 2 };

            Console.WriteLine($"Создать вектор размера: {n}");

            Vector vector1 = new Vector(n);

            Console.WriteLine($"vector1: {vector1}");

            Console.WriteLine($"Создать вектор из массива цифр: {string.Join(", ",numbersArray1)}");

            Vector vector2 = new Vector(numbersArray1);

            Console.WriteLine($"vector2: {vector2}");

            Console.WriteLine($"Создать массив размерности {n} и массива чисел {string.Join(", ", numbersArray1)}");

            Vector vector3 = new Vector(n, numbersArray1);

            Console.WriteLine($"vector3: {vector3}");

            Console.WriteLine("Создать копию вектора.");

            Vector vector4 = new Vector(vector3);

            Console.WriteLine($"vector4: {vector4}");

            Console.WriteLine($"Создать вектор из массива чисел: {string.Join(", ", numbersArray2)}");

            Vector vector5 = new Vector(numbersArray2);

            Console.WriteLine($"vector5: {vector5}");

            Console.WriteLine($"Получить вектор из суммы двух векторов {vector3} и {vector5}.");

            Vector vector6 = vector3.GetSum(vector5);

            Console.WriteLine($"vector6: {vector6}");

            Console.WriteLine($"Получить разворот вектора {vector6}");

            Vector vector7 = vector6.GetReverse();

            Console.WriteLine($"vector7: {vector7}");

            Console.WriteLine($"Умножить вектор {vector7} на скаляр {scalar}");

            Vector vector8 = vector7.GetScalar(scalar);

            Console.WriteLine($"vector8: {vector8}");

            Console.WriteLine($"Получить размер вектора: {vector8}");

            Console.WriteLine($"size: {vector8.GetSize()}");

            Console.WriteLine($"Вычесть из первого вектора {vector8} второй вектор {vector5}.");

            Vector vector9 = vector8.GetDifference(vector5);

            Console.WriteLine($"Результат вычитания vector9: {vector9}");

            Console.WriteLine($"Получить значения вектора: {vector9} под индексом: {vector9.Size - 5}.");

            Console.WriteLine($"Значения вектора vector9: {vector9.GetValue(vector9.Size - 5)}");

            Console.WriteLine($"Сравнить вектора: {vector3} и {vector4}");

            Console.WriteLine($"Результат сравнения: {vector3.Equals(vector4)}");

            Console.WriteLine($"Получить НashCode двух векторов  {vector3} и {vector4}");

            Console.WriteLine($"HashCode vector3: {vector3.GetHashCode()}");

            Console.WriteLine($"HashCode vector4: {vector4.GetHashCode()}");

            Console.WriteLine($"Получить вектор из суммы двух векторов: { vector3} и { vector5}.");

            Console.WriteLine($"Суммарный вектор: {Vector.GetSum(vector3, vector5)}");

            Console.WriteLine($"Вычесть из первого вектора {vector8} второй вектор {vector5}.");

            Console.WriteLine($"Вектор результата вычитания: {Vector.GetDifference(vector8, vector5)}");

            Console.WriteLine($"Получить скалярное произведение векторов {vector8} и {vector5}");

            Console.WriteLine($"Cкалярное произведение: {Vector.GetScalarMultiply(vector8, vector5)}");
        }
    }
}
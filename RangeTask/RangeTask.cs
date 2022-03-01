using System.Text;
namespace RangeTask
{
    public class RangeTask
    {
        public static void PrintArray(Range[] rangeArray)
        {
            string result = "";

            foreach (var item in rangeArray)
            {
                result += $"{item}, ";
            }

            if (rangeArray.Length == 0)
            {
                Console.WriteLine($"[]");
            }
            else
            {
                Console.WriteLine($"[{result.Remove(result.Length - 2, 2)}]");
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите диапазон вещественных чисел и число которое надо определить на этом диапазоне.");
            Console.Write("Введите начальное число диапазона: ");
            double from1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите конечное число диапазона: ");
            double to1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите предполагаемое вещественное число данного диапазона: ");
            double possibleNumber = Convert.ToDouble(Console.ReadLine());

            Range range1 = new Range(from1, to1);

            Console.Write($"Длинна диапазона чисел {from1} и {to1}: ");
            Console.WriteLine("{0:f2}", range1.GetLength());

            if (range1.IsInside(possibleNumber))
            {
                Console.WriteLine($"Число {possibleNumber} в заданном диапазоне вещественных чисел!");
            }
            else
            {
                Console.WriteLine($"Число {possibleNumber} не в заданном диапазоне вещественных чисел!");
            }

            Console.WriteLine("Нажмите любую клавишу для продолжения работы программы.");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Введите два диапазона вещественных чисел для  которых надо определить интервала-пересечения, объдинения и разности.");
            Console.Write("Введите начальное число первого диапазона: ");
            double from2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите конечное число первого диапазона: ");
            double to2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите начальное число второго диапазона: ");
            double from3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите конечное число второго диапазона: ");
            double to3 = Convert.ToDouble(Console.ReadLine());

            Range range2 = new Range(from2, to2);

            Console.WriteLine(range2.GetIntersection(from3, to3));

            PrintArray(range2.GetUnion(from3, to3));

            PrintArray(range2.GetDifference(from3, to3));
        }
    }
}
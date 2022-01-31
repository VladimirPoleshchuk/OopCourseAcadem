namespace RangeTask
{
    public class RangeTask
    {
        static void Main()
        {
            Console.WriteLine("Введите диапазон вещественных чисел и число которое надо определить на этом диапазоне.");
            Console.Write("Введите начальное число диапазона: ");
            double fromNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите конечное число диапазона: ");
            double toNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите предполагаемое вещественное число данного диапазона: ");
            double possibleNumber = Convert.ToDouble(Console.ReadLine());

            Range range = new Range(fromNumber, toNumber);

            Console.Write($"Длинна диапазона чисел {fromNumber} и {toNumber}: ");
            Console.WriteLine("{0:f2}", range.GetLength());

            if (range.IsInside(possibleNumber))
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
            double fromNumber1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите конечное число первого диапазона: ");
            double toNumber1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите начальное число второго диапазона: ");
            double fromNumber2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите конечное число второго диапазона: ");
            double toNumber2 = Convert.ToDouble(Console.ReadLine());

            Range range1 = new Range(fromNumber1, toNumber1);

            Range range2 = new Range(fromNumber2, toNumber2);
            
            Range twoRanges = new(range1, range2);
            
            Console.WriteLine(twoRanges.GetIntersection());

            Console.WriteLine(twoRanges.GetUnion());

            Console.WriteLine(twoRanges.GetDifference());
        }
    }
}
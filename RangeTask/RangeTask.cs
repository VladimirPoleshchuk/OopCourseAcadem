using System;

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

            Console.Clear();

            Range numbersRange = new Range(fromNumber, toNumber);

            Console.Write($"Длинна диапазона чисел {fromNumber} и {toNumber}: ");
            Console.WriteLine("{0:f5}", numbersRange.GetLength());

            if (numbersRange.IsInside(possibleNumber))
            {
                Console.WriteLine($"Число {possibleNumber} в заданном диапазоне вещественных чисел!");
            }
            else
            {
                Console.WriteLine($"Число {possibleNumber} не в заданном диапазоне вещественных чисел!");
            }
        }
    }
}
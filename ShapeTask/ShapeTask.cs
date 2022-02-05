
using System.Collections;

namespace ShapeTask
{
    public class ShapeTask
    {
        static IShape GetMaxAreaShape(IShape[] shapes)
        {
            IShape max = shapes[0];

            for (int i = 1; i < shapes.Length; i++)
            {
                if (shapes[i - 1].GetArea() < shapes[i].GetArea())
                {
                    max = shapes[i];
                }
            }

            return max;
        }

        public static void Main()
        {
            IShape circle1 = new Circle(2.0);
            IShape circle2 = new Circle(2.2);

            IShape rectangle1 = new Rectangle(3, 5.6);

            IShape square1 = new Square(4);

            IShape triangle1 = new Triangle(1, 2.3, -3, 3.3, -2.1, -5);
            IShape triangle2 = new Triangle(2, 3, 4, -2, -3, -1);

            IShape[] shapes = { circle1, circle2, rectangle1, square1, triangle1, triangle2 };

            IShape maxAreaShape = GetMaxAreaShape(shapes);

            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetArea());
            }

            Console.WriteLine("--------------");

            Console.WriteLine("Площадь фигуры: {0:f2}, Высота: {1:f2}, Ширина: {2:f2}, Периметр: {3:f2}, Тип фигуры: {4}",
                              maxAreaShape.GetArea(), maxAreaShape.GetHeight(), maxAreaShape.GetWidth(), maxAreaShape.GetPerimeter(), maxAreaShape.GetType());
        }
    }
}
using System.Drawing;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть довжину першої сторони прямокутника:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть довжину другої сторони прямокутника:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
    }
}
class Program
{
    static void Main()
    {
        Point point1 = new Point(0, 0, "A");
        Point point2 = new Point(0, 4, "B");
        Point point3 = new Point(3, 0, "C");

        Figure triangle = new Figure(point1, point2, point3);
        triangle.CalculatePerimeter();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square1 = new Square("blue", 4);
        Rectangle rect1 = new Rectangle("red", 3, 2);
        Circle circle1 = new Circle("yellow", 2);
        shapes.Add(square1);
        shapes.Add(rect1);
        shapes.Add(circle1);

        foreach (Shape s in shapes) 
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
            Console.WriteLine();
        }
    }
}
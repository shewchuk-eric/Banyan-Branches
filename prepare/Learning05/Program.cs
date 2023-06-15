using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>{};
        Shape block = new Square("blue", 4);
        shapes.Add(block);
        Shape block2 = new Rectangle("green", 4, 10);
        shapes.Add(block2);
        Shape sphere = new Circle("red", 4);
        shapes.Add(sphere);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The color is {shape.GetColor()} and the area is {shape.GetArea()}");
        }
    }
}
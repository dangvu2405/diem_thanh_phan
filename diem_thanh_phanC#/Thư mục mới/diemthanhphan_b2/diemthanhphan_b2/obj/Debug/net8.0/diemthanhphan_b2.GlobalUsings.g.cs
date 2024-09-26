using System;

interface IShape
{
    double CalculateArea();
}

class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();

        Console.WriteLine("Nhập bán kính của hình tròn:");
        circle.Radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập chiều rộng của hình chữ nhật:");
        rectangle.Width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập chiều cao của hình chữ nhật:");
        rectangle.Height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Diện tích của hình tròn: {circle.CalculateArea():F2}");
        Console.WriteLine($"Diện tích của hình chữ nhật: {rectangle.CalculateArea():F2}");
    }
}

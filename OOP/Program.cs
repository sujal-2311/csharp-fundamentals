var rectangle1 = new Rectangle(5, 10);
var rectangle2 = new Rectangle(50, 100);

Console.WriteLine(
    "Count of Rectangle objects is " + Rectangle.CountOfInstances);

//Console.WriteLine("Width is " + rectangle1.Width);
//Console.WriteLine("Height is " + rectangle1.GetHeight());
//Console.WriteLine("Area is " + rectangle1.CalculateArea());
//Console.WriteLine("Circumference is " + rectangle1.CalculatePerimeter());

//var rectangle1 = new Rectangle(5, 10);

//Console.WriteLine("width is: " + rectangle1.Width);
//Console.WriteLine("height is: " + rectangle1.Height);
//Console.WriteLine("Area is: " + rectangle1.CalculateArea());
//Console.WriteLine("Circumference is: " + rectangle1.CalculateCircumference());

//var rectangle2 = new Rectangle(2, 3);

//Console.WriteLine(rectangle2.Width);
//Console.WriteLine(rectangle2.Height);
//Console.WriteLine("Area is: " + rectangle2.CalculateArea());
//Console.WriteLine("Circumference is: " + rectangle2.CalculateCircumference());

class Rectangle
{
    public static int CountOfInstances { get; private set; }
    private static DateTime _fisrstUsed = DateTime.Now;
    public int Width = 3;
    public int Height = 4;

    static Rectangle()
    {
        _fisrstUsed = DateTime.Now;
    }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
        ++CountOfInstances;
    }
    public int CalculateCircumference()
    {
        return 2 * Width + 2 * Height;
    }
    public int CalculateArea()
    {
        return Width * Height;
    }
}
class Pentagon
{
    private double side;

    public Pentagon()
    { 
       side = 0;

    }

    public Pentagon(double SideLength)
    {
        side = SideLength;
    }

    public double GetPerimeter()
    {
        return side * 5;
    }

    public double GetArea()
    {
        double Area = (Math.Sqrt(5 * (5 + 2 * (Math.Sqrt(5))) * Math.Pow(side, 2)) / 4);
        return Area;
    }

    public void Display()
    {
        Console.WriteLine($"Side length: {side}");
        Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
        Console.WriteLine($"Side length: {GetArea():F3}");

    }

    public static void Main(string[] args)
    {
        Pentagon p1 = new Pentagon();
        Console.WriteLine("Pentagon p1");
        Console.WriteLine("-------------------------");
        p1.Display();

        Console.WriteLine();
        Console.WriteLine();

        Pentagon p2 = new Pentagon(5);
        Console.WriteLine("Pentagon p2");
        Console.WriteLine("-------------------------");
        p2.Display();
    }
}

public class Program
{
    public record struct point(int X, int Y);
    public struct Point
    {
        public int X;
        public int Y;
    }
    public static void Main(string[] args)
    {


Point p = new Point { X = 10, Y = 20 };

Console.WriteLine(p);
Console.WriteLine($"P x {p.X} y{p.Y}");


     

    point p_ = new point(10, 20);

    Console.WriteLine(p_);
    }
}

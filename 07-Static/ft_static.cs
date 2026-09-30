public static class ft_Static
{
    public static int num_x = 10;
    public static int num_y = -8;

    // static ft_Static()
    // {
    //     num_x = 10;
    //     num_y = -8;
    // }
    public static int Add(int x, int y)
    {
        Console.WriteLine($"X: {num_x} Y:{num_y}");
        return (x+y);
    }
}

// real example: Math.Abs(-10); 
// class AdvancedCalculator : Calculator // ❌ {} Error :(
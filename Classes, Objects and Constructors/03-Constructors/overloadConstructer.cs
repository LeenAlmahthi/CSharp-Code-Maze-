//For overloading, C# looks at:
//Number of parameters
//        +
//Parameter types
//        +
//Order of parameter types
public class OverloadConstructer
{
    public int X;
    public int Y;
    public OverloadConstructer()
    {
        X = 0;
        Y = 0;
    }
    public OverloadConstructer(int x, int y)
    {
        X = x;
        Y = y;
    }
    public OverloadConstructer(int x)
    {
        X = x;
        Y = 0;
    }
    public OverloadConstructer(int y)
    {
        X = 0;
        Y = y;
    }
}
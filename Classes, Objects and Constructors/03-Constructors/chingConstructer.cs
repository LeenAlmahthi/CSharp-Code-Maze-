public class ChingConstructer
{
    public int X;
    public int Y;
    public ChingConstructer(): this(0, 0)
	{
    }
	public ChingConstructer(int x): this(x, 0)
	{
    }
    public ChingConstructer(int y) : this(0, y)
	{
    }
	public ChingConstructer(int x, int y)
	{
		X = x;
		Y = y;
	}
}
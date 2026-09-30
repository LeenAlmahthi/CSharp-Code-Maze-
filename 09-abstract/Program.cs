public class Program
{
    static void Main()
    {
        var car = new Porsche();

        car.type();
        car.message();

        var _car = new Bmw();

        _car.type();
        _car.message();
    }
}
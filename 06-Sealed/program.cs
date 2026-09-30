public class program
{
    public static void Main(string[] args)
    {
        Car car = new Car
        {
            make = "BMW",
            model = "X5",
            year = 2022
        };
        Bmw bmw = new Bmw
        {
            make = "BMW",
            model = "X5",
            year = 2022,
        };
        car.carSealed();
        bmw.carSealed();
        car.car1();
        bmw.car1();
    }
}
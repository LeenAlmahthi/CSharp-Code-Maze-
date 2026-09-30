public class program
{
    public static void Main(string[] args)
    {
        // Create an instance of the Car class
        // Object creation + property assignment
        Car car = new Car();
        car.make = "BMW";
        car.model = "X5";
        car.year = 2022;
        // Object initializer
        Car _car = new Car
        {
            make = "BMW",
            model = "X5",
            year = 2022
        };
        // Parameterized constructor + object initializer
        Car _car_1 = new Car("Bmw",2026)
        {
            model = "X5",
        };
        // Constructor only
        var car1 = new Car("BMW", 2022);
        Console.WriteLine(car.make); // Accessing the read-only property 
    }
}
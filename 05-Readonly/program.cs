//C# code snippet demonstrating the use of a read-only property and a private field with a method to access it.
public class program
{
    public static void Main(string[] args)
    {
        Car car = new Car("BMW");
        Console.WriteLine(car.Make); // Accessing the read-only property 
        Console.WriteLine(car.getmake()); // Accessing the private field through the method 
    }
}
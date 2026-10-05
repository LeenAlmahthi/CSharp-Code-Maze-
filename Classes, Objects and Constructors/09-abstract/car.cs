public abstract class Car
{
    // ABSTRACT CLASS
    // We cannot create an object directly from Car:
    //
    // var car = new Car(); // ❌
    //
    // The purpose of Car is to be a base class
    // for classes such as BMW and Porsche.


    // NORMAL METHOD
    // This method already has an implementation.
    // Derived classes inherit this method and can use it directly.
    public void message ()
    {
        Console.WriteLine("This Message From a abstract Class :)");
    }
    // ABSTRACT METHOD
    // This is only the declaration/signature.
    // There is NO implementation here.
    //
    // Every non-abstract class that inherits from Car
    // must implement this method using override.
    public abstract void type(); 
}

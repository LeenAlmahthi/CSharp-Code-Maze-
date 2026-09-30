public class Bmw : Car
{
    // BMW inherits from the abstract Car class.
    // Because Car has an abstract method called type(),
    // BMW MUST implement it using override.
    public override void type()
    {
         Console.WriteLine("This Message From a BMW Class :)");
    }
}
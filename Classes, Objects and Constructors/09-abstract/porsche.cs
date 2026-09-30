public class Porsche : Car
{ 
    // Porsche inherits from Car.
    // Car requires type() to be implemented,
    // so Porsche provides its own implementation.
    public override void type()
    {
         Console.WriteLine("This Message From a Porsche Class :)");
    }
}
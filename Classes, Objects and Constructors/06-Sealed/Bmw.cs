
public sealed class Bmw : Car 
{
    public Bmw()
    { }
    public Bmw(string make, int year)
    {
        this.make = make;
        if (year < 1886)
            throw new ArgumentException("Year must be 1886 or later.");
        this.year = year;
    }

    //static void cars()
    //{ 
    //    console.log("The static is mean : this functions belong to this class");
    //}

    //-> give u these Error :(
    //C:\Users\leen.almahth\source\repos\CSharp-code-maze\sealed\car.cs(16,17): error CS0238: 'Bmw.car()' cannot be sealed because it is not an override
    //C:\Users\leen.almahth\source\repos\CSharp-code-maze\sealed\Bmw.cs(21,17): error CS0238: 'Car.car()' cannot be sealed because it is not an override
    //C:\Users\leen.almahth\source\repos\CSharp-code-maze\sealed\Bmw.cs(25,19): error CS0621: 'Car.car1()': virtual or abstract members cannot be private
    //C:\Users\leen.almahth\source\repos\CSharp-code-maze\sealed\Bmw.cs(25,19): error CS0115: 'Car.car1()': no suitable method found to override
    public override void car1()
    {
        Console.WriteLine("The virtual function is mean : this function can be override");
    }

    public override sealed void carSealed()
    {
        Console.WriteLine("The sealed  function is mean : this function cannot be override");
    }
  
}

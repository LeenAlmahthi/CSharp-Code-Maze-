public class Car
{
    // in the base class we can't add a seaded function because the sealed function is mean : this function cannot be override
    // but in the base class we can add a virtual function because the virtual function is mean : this function can be override
    public string make { get; set; }
    public string model { get; set; }
    public int year { get; set; }

    public Car()
    {
    }
    public Car(string make, int year)
    {
        this.make = make;
        if (year < 1886)
            throw new ArgumentException("Year must be 1886 or later.");
        this.year = year;
    }
    public static void cars()
    {
        Console.WriteLine("base class:  The static is mean : this functions belong to this class");
    }
    public virtual void carSealed()
    {
        Console.WriteLine("base class: The sealed  function is mean : this function cannot be override");
    }
    public virtual void car1()
    {
        Console.WriteLine("base class: The virtual function is mean : this function can be override");
    }
}
public class Car
{
    public string make { get; set; }
    public string model { get; set; }
    int year { get; set; }
    //CONSTRUCTOR
    //     ↓
    //  "These values are required to create a valid object, can validation the input"
    //     ↓
    //  new Car("BMW", 2022);
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
    // object Initialize
    // var car = new Car {
    // make = "BMW",
    // year = 2020
    // };
}

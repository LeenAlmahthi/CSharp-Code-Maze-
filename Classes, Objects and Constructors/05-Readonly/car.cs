public class Car {
    private readonly string make;
    private string model;
    private int year;
    //there are a 2 way to access the private field 
    /* [prototype] */
    public string Make => make; // prototype for a read-only property 
    /* [Methods] */   public string  getmake () { return (make); } 
    public string Model => model; // prototype for a read-write property
    public int Year => year;    // prototype for a read-write property


}       
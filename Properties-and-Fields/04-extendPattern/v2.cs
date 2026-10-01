
public class Program
{
    public record Address(string City, string Country);
    public record University(string Name, Address Address);
    public record Student(
      string Name,
      int Age,
      University University
    );

    public static string CheckStudent(Student student)
    {
        string re = "From a ";
        re += student switch
        {
            { University.Address.Country: "Jordan" } => "Jordan Adult Student",
            _ => "other Student"
        };
        re += " In ";
        re += student switch
        {
            { University.Address.City: "Amman" } => "Amman Student",
            _ => "other Student"
        };
        re += " There University is ";
        re += student switch
        {
            { University.Name: "Al-Balqa" } => "Al-Balqa University",
            _ => "other Student"
        };
        return re;
    }
    public static void Main()
    {
        var sara = new Student("sara", 22, new University("Al-Balqa", new Address("Amman", "Jordan")));
        var q = new Student("John", 20, new University("Another University", new Address("Irbid", "Jordan")));
        Console.WriteLine(CheckStudent(q));
        Console.WriteLine(CheckStudent(sara));
    }
}

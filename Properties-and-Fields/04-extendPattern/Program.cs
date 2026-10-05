using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

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
        return student switch
        {
            {University.Address.City :"Amman" } => "Amman Student",
            {University.Address.Country: "Jordan",
                Age: >=18 } => "Jordan Adult Student",
            {University.Name :"Al-Balqa" } => "Al-Balqa Student",
            _ => "Other Student"
        };
    }
    public static void Main()
    {
        var sara = new Student("sara",22, new University("Al-Balqa", new Address("Amman", "Jordan")));
        var q = new Student("John",20, new University("Another University", new Address("Irbid", "Jordan")));
        // Console.WriteLine(CheckStudent(student));
        Console.WriteLine(CheckStudent(sara));
        Console.WriteLine(CheckStudent(q));
    }
}

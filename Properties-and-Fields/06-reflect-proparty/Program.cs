// using System.Reflection.Metadata.Ecma335;
// using System.Runtime.CompilerServices;
// using System.Security.Cryptography;

// public class Program
// {
//     public class Person
//     {
//         public int Age;
//         public string Name = null!;
//     }
//     public static void Main()
//     {

//         Person person = new()
//         {
//             Name = "Leen",
//             Age = 22
//         };

//         string propertyName = "Age";

//         PropertyInfo? property =
//             typeof(Person).GetProperty(propertyName);

//         object? value =
//             property?.GetValue(person);
//         Console.WriteLine(property, value);
//     }
// }
using System.Reflection;

public class Program
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; } = null!;
    }

    public static void Main()
    {
        Person person = new()
        {
            Name = "Leen",
            Age = 22
        };

        string propertyName = "Age";

        PropertyInfo? property =
            typeof(Person).GetProperty(propertyName);
        // holds information about the Age property.
        object? value =
            property?.GetValue(person);
        // GetValue() returns an object? because the property can have different types, so Reflection exposes the result as object. 

        Console.WriteLine(value);
    }
}
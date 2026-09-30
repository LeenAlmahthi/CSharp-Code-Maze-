public class progarm
{
    public record User(string FirstName, string LastName);
    public record struct Admin(string FirstName, string LastName, string Role);
    static void Main()
    {
        //user ────┐
        // ↓
        //[John, Doe]
        // ↑
        //copy ────┘
        var user = new User("John", "Doe");
        var copy = user;

        //admin     → [Jane, Smith, SuperAdmin]
        //adminCopy → [Jane, Smith, SuperAdmin]
        
        var admin = new Admin("Jane", "Smith", "SuperAdmin");
        var adminCopy = admin;
        Console.WriteLine(ReferenceEquals(user, copy)); // this compares the references of user and copy, which are equal because they point to the same object in memory
        Console.WriteLine(ReferenceEquals(admin, adminCopy)); 
        if (user == copy) // this compares the values of user and copy, which are equal because they have the same property values
            Console.WriteLine("User and copy are equal."); 
        if (admin == adminCopy)
            Console.WriteLine("admin and copy are equal.");
        else
            Console.WriteLine("admin and copy are not equal");
    }
}
using System.Dynamic;
using Microsoft.VisualBasic;

public class Account
{
    public required string NumberPhone ; // required Must be define by his name proparity 
    // VariantType q = new Account
    // {
    //     NumberPhone = "0000000"
    // }
    // or 
    // q.NumberPhone = "00000";
    private string username;
    public int id {get; set;} = 88;  // Default Value  
    public string Username   // This Call auto proparity  
    {
        set
        {
            if (value.Length >= 10)
                throw new ArgumentException("unvalide username ");
            Username = value;
        }
        get => username;
    }
    public Account()
    {
        username = "defualt";
    }
    public override string ToString()
    {
        return $"username: {Username},\n Numberphone: {NumberPhone},\n Id: {id} ";
    }
}
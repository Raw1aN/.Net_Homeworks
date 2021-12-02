namespace Classwork_26._10._21.Models
{
    public record UserProfile(string? FirstName,string? LastName, Sex? Sex,int Age)
    {
        
    }

    public enum Sex
    {
        Male,
        Female
    }
    
    
}
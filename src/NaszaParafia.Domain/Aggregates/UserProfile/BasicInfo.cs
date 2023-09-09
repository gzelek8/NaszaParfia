namespace NaszaParafia.Domain.Aggregates.UserProfile;

public class BasicInfo
{
    private BasicInfo() { }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public string CurrentCity { get; private set; }

    // Factory method
    public static BasicInfo CreateBasicInfo(
        string firstName,
        string lastName,
        string email,
        string phone,
        string currentCity,
        DateTime dateOfBirth
    )
    {
        return new BasicInfo
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Phone = phone,
            CurrentCity = currentCity,
            DateOfBirth = dateOfBirth
        };
    }
}

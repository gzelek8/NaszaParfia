namespace NaszaParafia.Domain.Aggregates.Priest;

public class Priest
{
    private readonly List<Mass> _masses = new List<Mass>();

    private Priest() { }

    public Guid PriestId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime LastModify { get; set; }
    public Guid ParishId { get; set; }
    public IEnumerable<Mass> Masses { get; set; }

    // Factory method
    public static Priest CreatePriest(
        Guid parishId,
        string firstName,
        string lastName,
        string phone,
        string email,
        DateTime dateOfBirth
    )
    {
        return new Priest
        {
            ParishId = parishId,
            FirstName = firstName,
            LastName = lastName,
            Phone = phone,
            Email = email,
            DateOfBirth = dateOfBirth,
            CreatedDate = DateTime.UtcNow,
            LastModify = DateTime.UtcNow
        };
    }

    // Public methods
    public void AddMass(Mass mass)
    {
        _masses.Add(mass);
    }

    public void RemoveMass(Mass mass)
    {
        _masses.Remove(mass);
    }
}

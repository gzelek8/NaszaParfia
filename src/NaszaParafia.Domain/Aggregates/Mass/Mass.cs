namespace NaszaParafia.Domain.Aggregates.Mass;

public class Mass
{
    private Mass() { }

    public Guid MassId { get; private set; }
    public Guid ParaffinProfileId { get; private set; }
    public Guid ParishId { get; private set; }
    public Guid PriestId { get; private set; }
    public string Intention { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public DateTime LastModify { get; private set; }
    public DateTime DateOfCelebration { get; private set; }

    // Factory method
    public static Mass CreateMass(
        Guid paraffinProfileId,
        string intention,
        DateTime dateOfCelebration
    )
    {
        return new Mass
        {
            ParaffinProfileId = paraffinProfileId,
            Intention = intention,
            DateOfCelebration = dateOfCelebration,
            CreatedDate = DateTime.UtcNow,
            LastModify = DateTime.UtcNow
        };
    }

    // Public methods
    public void AssignPriest(Guid priestId)
    {
        PriestId = priestId;
        LastModify = DateTime.UtcNow;
    }

    public void AssignParish(Guid parishId)
    {
        ParishId = parishId;
        LastModify = DateTime.UtcNow;
    }
}

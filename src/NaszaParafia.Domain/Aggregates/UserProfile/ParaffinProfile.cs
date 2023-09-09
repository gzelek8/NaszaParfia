namespace NaszaParafia.Domain.Aggregates.UserProfile;

public class ParaffinProfile
{
    private ParaffinProfile() { }

    public Guid ParaffinProfileId { get; private set; }
    public string IdentityId { get; private set; }
    public BasicInfo BasicInfo { get; private set; }
    public DateTime DateCreated { get; private set; }
    public DateTime LastModify { get; private set; }

    // Factory method
    public static ParaffinProfile CreateParaffinProfile(string identityId, BasicInfo basicInfo)
    {
        return new ParaffinProfile
        {
            IdentityId = identityId,
            BasicInfo = basicInfo,
            DateCreated = DateTime.UtcNow,
            LastModify = DateTime.UtcNow
        };
    }

    // Public method
    public void UpdateBasicInfo(BasicInfo newBasicInfo)
    {
        BasicInfo = newBasicInfo;
        LastModify = DateTime.UtcNow;
    }
}

using System;
using NaszaParafia.Domain.Aggregates.UserProfile;
using NaszaParafia.Domain.ValueObjects;

namespace NaszaParafia.Domain.Aggregates.Parish;

public class Parish
{
    private readonly List<Priest> _priests = new List<Priest>();
    private readonly List<Mass> _masses = new List<Mass>();
    private readonly List<ParaffinProfile> _parishioners = new List<ParaffinProfile>();

    private Parish() { }

    public Guid ParishId { get; private set; }
    public IEnumerable<Priest> Priests
    {
        get { return _priests; }
    }
    public IEnumerable<ParaffinProfile> Parishioners
    {
        get { return _parishioners; }
    }
    public IEnumerable<Mass> Masses
    {
        get { return _masses; }
    }
    public string Name { get; set; }
    public string Address { get; set; }
    public GeoJsonPoint Location { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime LastModify { get; set; }

    // Factory method
    public static Parish CreateParish(string name, string address, GeoJsonPoint location)
    {
        return new Parish
        {
            Name = name,
            Address = address,
            Location = location,
            CreatedDate = DateTime.UtcNow,
            LastModify = DateTime.UtcNow
        };
    }

    // Public methods
    public void AddPriest(Priest priest)
    {
        _priests.Add(priest);
        LastModify = DateTime.UtcNow;
    }

    public void RemovePriest(Priest priest)
    {
        _priests.Remove(priest);
        LastModify = DateTime.UtcNow;
    }

    public void AddMass(Mass mass)
    {
        _masses.Add(mass);
        LastModify = DateTime.UtcNow;
    }

    public void RemoveMass(Mass mass)
    {
        _masses.Remove(mass);
        LastModify = DateTime.UtcNow;
    }

    public void AddParaffin(ParaffinProfile paraffin)
    {
        _parishioners.Add(paraffin);
        LastModify = DateTime.UtcNow;
    }

    public void RemoveParaffin(ParaffinProfile paraffin)
    {
        _parishioners.Remove(paraffin);
        LastModify = DateTime.UtcNow;
    }
}

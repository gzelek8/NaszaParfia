namespace NaszaParafia.Domain.Entities
{
    public class Paraffin
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ParishId { get; set; }
        public Parish Parish { get; set; }
        public ICollection<Mass> Masses { get; set; }
    }
}
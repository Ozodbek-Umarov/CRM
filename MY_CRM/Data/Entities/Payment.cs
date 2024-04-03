namespace MY_CRM.Data.Entities;

public class Payment : BaseEntity
{
    public string Name { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
}

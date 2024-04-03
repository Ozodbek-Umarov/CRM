namespace MY_CRM.Data.Entities;

public class PaymentTable : BaseEntity
{
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int PaymentId { get; set; }
    public Payment Payment { get; set; }
}

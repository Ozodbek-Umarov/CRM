namespace MY_CRM.Data.Entities;

public class Teacher : BaseEntity
{
    public string FullName { get; set; }
    public int SubjectId { get; set; }
    public Subject Subject { get; set; }
}

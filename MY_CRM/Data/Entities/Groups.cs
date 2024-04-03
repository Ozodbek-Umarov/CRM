namespace MY_CRM.Data.Entities;

public class Groups : BaseEntity
{
    public string Name { get; set; }
    public List<Student> Students { get; set; } = new();
    public List<Teacher> Teachers { get; set; } = new();
}

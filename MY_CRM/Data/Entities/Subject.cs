namespace MY_CRM.Data.Entities;

public class Subject : BaseEntity
{
    public string Name { get; set; }
    public List<Teacher> Teachers { get; set; } = new();
}

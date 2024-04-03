namespace MY_CRM.Data.Entities;

public class Student : BaseEntity
{
    public string FullName { get; set; }
    public int GroupId { get; set; }
    public Groups Group { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
}

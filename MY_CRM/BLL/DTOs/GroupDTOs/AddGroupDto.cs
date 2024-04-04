using MY_CRM.Data.Entities;

namespace MY_CRM.BLL.DTOs.GroupDTOs;

public class AddGroupDto
{
    public string Name { get; set; }
    public int StudentId { get; set; }
    public List<Student> Students { get; set; } = new();
    public int TeacherId { get; set; }
    public List<Teacher> Teachers { get; set; } = new();
}

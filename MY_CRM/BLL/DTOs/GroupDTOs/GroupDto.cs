using MY_CRM.Data.Entities;

namespace MY_CRM.BLL.DTOs.GroupDTOs;

public class GroupDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Student Student { get; set; }
    public Teacher Teacher { get; set; }
}

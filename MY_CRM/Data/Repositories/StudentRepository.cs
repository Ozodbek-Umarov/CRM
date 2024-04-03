using MY_CRM.Data.Entities;
using MY_CRM.Data.Interfaces;

namespace MY_CRM.Data.Repositories;

public class StudentRepository (AppDbContext dbContext)
    : Repository<Student>(dbContext), IStudentInterface
{
}

using MY_CRM.Data.Entities;
using MY_CRM.Data.Interfaces;

namespace MY_CRM.Data.Repositories;

public class SubjectRepository(AppDbContext dbContext)
    :Repository<Subject>(dbContext) , ISubjectInterface
{
}

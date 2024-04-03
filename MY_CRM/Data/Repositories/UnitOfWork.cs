using MY_CRM.Data.Interfaces;

namespace MY_CRM.Data.Repositories;

public class UnitOfWork(AppDbContext dbContext)
    : IUnitOfWork
{
    public IGroupInterface Groups => new GroupRepository(dbContext);

    public IPaymentInterface Payments => new PaymentRepository(dbContext);

    public IPaymentTableInterface PaymentTables => new PaymentTableRepository(dbContext);

    public IStudentInterface Students => new StudentRepository(dbContext);

    public ISubjectInterface Subjects => new SubjectRepository(dbContext);

    public ITeacherInterface Teachers => new TeacherRepository(dbContext);
}

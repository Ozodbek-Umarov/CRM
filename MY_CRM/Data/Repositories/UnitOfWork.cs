using MY_CRM.Data.Interfaces;

namespace MY_CRM.Data.Repositories;

public class UnitOfWork(AppDbContext dbContext)
    : IUnitOfWork
{
    public IGroupInterface GroupInterface => new GroupRepository(dbContext);

    public IPaymentInterface PaymentInterface => new PaymentRepository(dbContext);

    public IPaymentTableInterface PaymentTableInterface => new PaymentTableRepository(dbContext);

    public IStudentInterface StudentInterface => new StudentRepository(dbContext);

    public ISubjectInterface SubjectInterface => new SubjectRepository(dbContext);

    public ITeacherInterface TeacherInterface => new TeacherRepository(dbContext);
}

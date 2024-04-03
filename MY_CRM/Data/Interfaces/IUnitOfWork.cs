namespace MY_CRM.Data.Interfaces;

public interface IUnitOfWork
{
    IGroupInterface Groups { get; }
    IPaymentInterface Payments { get; }
    IPaymentTableInterface PaymentTables { get; }
    IStudentInterface Students { get; }
    ISubjectInterface Subjects { get; }
    ITeacherInterface Teachers { get; }
}

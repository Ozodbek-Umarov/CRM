namespace MY_CRM.Data.Interfaces;

public interface IUnitOfWork
{
    IGroupInterface GroupInterface { get; }
    IPaymentInterface PaymentInterface { get; }
    IPaymentTableInterface PaymentTableInterface { get; }
    IStudentInterface StudentInterface { get; }
    ISubjectInterface SubjectInterface { get; }
    ITeacherInterface TeacherInterface { get; }
}

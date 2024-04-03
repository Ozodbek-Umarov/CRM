using MY_CRM.Data.Entities;
using MY_CRM.Data.Interfaces;

namespace MY_CRM.Data.Repositories;

public class PaymentTableRepository (AppDbContext dbContext)
    : Repository<PaymentTable>(dbContext) , IPaymentTableInterface
{
}

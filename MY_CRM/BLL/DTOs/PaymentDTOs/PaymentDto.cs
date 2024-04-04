using MY_CRM.Data.Entities;

namespace MY_CRM.BLL.DTOs.PaymentDTOs;

public class PaymentDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public static implicit operator PaymentDto(Payment payment)
        => new()
        {
            Id = payment.Id,
            Name = payment.Name,
        };
}

using SOLID.Enums;

namespace SOLID.Entities
{
    public class PaymentResponse
    {
        public StatusEnums Status { get; set; }
        public string? TransactionId { get; set; }
        public required string Mensagem { get; set; }
    }
}

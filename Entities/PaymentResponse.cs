using SOLID.Enums;

namespace SOLID.Entities
{
    public class PaymentResponse
    {
        public StatusEnums Status { get; set; }
        public int TransactionId { get; set; }
        public required string Mensagem { get; set; }
    }
}

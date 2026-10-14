using SOLID.Enums;

namespace SOLID
{
    public class OrderRequest
    {
        public int Id { get; set; }

        public required string CustomerName { get; set; }

        public required string CustomerEmail { get; set; }

        public decimal Total { get; set; }
        
        public string? DiscountType { get; set; }

        public StatusEnums Status { get; set; }
    }
}

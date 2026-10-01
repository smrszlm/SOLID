using SOLID.Enums;

namespace SOLID.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public required string CustomerName { get; set; }

        public required string CustomerEmail { get; set; }

        public decimal Total { get; set; }

        public StatusEnums Status { get; set; }
    }
}

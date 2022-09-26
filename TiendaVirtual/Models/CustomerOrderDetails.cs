namespace TiendaVirtual.Models
{
    public partial class CustomerOrderDetails
    {
        public int OrderDetailId { get; set; }

        public string OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}

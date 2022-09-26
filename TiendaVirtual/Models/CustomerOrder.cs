namespace TiendaVirtual.Models
{
    public partial class CustomerOrder
    {
        public int OrderId { get; set; }

        public int UserId { get; set; }

        public DateTime DateCreated { get; set; }

        public decimal CartTotal { get; set; }
    }
}

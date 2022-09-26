namespace TiendaVirtual.Models
{
    public partial class CartItem
    {
        public int CartItemId { get; set; }

        public string CartId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}

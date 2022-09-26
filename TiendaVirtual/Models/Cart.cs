namespace TiendaVirtual.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }

        public int UserId { get; set; }

        public DateTime DateCreated { get; set; }
    }
}

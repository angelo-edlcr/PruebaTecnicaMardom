namespace TiendaVirtual.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }
    }
}

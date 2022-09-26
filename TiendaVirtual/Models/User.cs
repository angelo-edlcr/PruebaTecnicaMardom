namespace TiendaVirtual.Models
{
    public partial class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Gender { get; set; }

        public int UserTypeId { get; set; }
    }
}

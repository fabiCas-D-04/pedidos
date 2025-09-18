namespace pedidos.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public int rol { get; set; }

        public ICollection<Order> Pedidos { get; set; }
    }
}

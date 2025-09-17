namespace pedidos.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int Estado { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }

        public User Cliente { get; set; }
        public ICollection<OrderItem> DetallePedidos { get; set; }
    }
}
﻿namespace pedidos.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Stock { get; set; }
        public string descripcion { get; set; }

    public ICollection<OrderItem> DetallePedidos { get; set; }
    }
}
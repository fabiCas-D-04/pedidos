﻿namespace pedidos.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        
        public string Rol { get; set; }

        public ICollection<Order> Pedidos { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BackendCoffeeNet.Models
{
    public class Usuarios
    {
        [Key]
        public int Id_usuario { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string NombreUsuario { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set;} = string.Empty;

        public string Telefono { get; set;} = string.Empty;

        public string Rol { get; set;} = string.Empty;

        public DateTime Fecha_Registro { get; set;}

        public DateTime Fecha_Actualizacion { get; set; }

        public bool Estado { get; set; }

        public DateTime Fecha_Baja { get; set;} 

        // Propiedad de navegación COLECCIÓN: muestra los pedidos de un usuario
        public ICollection<Pedidos> Pedidos {get; set; } = new List<Pedidos>();
        
    }
}
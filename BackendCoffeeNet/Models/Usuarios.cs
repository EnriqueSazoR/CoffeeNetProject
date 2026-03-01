using System.ComponentModel.DataAnnotations;

namespace BackendCoffeeNet.Models
{
    public class Usuarios
    {
        [Key]
        public int Id_usuario { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set;} = string.Empty;

        public string Telefono { get; set;} = string.Empty;

        public string Rol { get; set;} = string.Empty;

        public DateTime Fecha_Registro { get; set;} 

        public bool Estado { get; set; }

        public DateTime Fecha_Baja { get; set;} 
        
    }
}
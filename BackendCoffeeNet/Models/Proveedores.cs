using System.ComponentModel.DataAnnotations;

namespace BackendCoffeeNet.Models
{
    public class Proveedores
    {
        [Key]
        public int Id_Proveedor { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public bool Estado { get; set; }
        
    }
}
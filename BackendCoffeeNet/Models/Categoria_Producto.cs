using System.ComponentModel.DataAnnotations;

namespace BackendCoffeeNet.Models
{
    public class Categoria_Producto
    {
        [Key]
        public int Id_categoria { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public bool Estado { get; set; }

        public DateTime Fecha_modificado { get; set;}
        
    }
}
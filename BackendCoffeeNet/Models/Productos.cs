using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendCoffeeNet.Models
{
    public class Productos
    {
        [Key]
        public int Id_Producto { get; set; }

        // Llave foránea
        public int Id_Categoria { get; set; }
        [ForeignKey("Id_Categoria")]
        public Categoria_Producto Categoria {get; set;} = null!;

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioVenta { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CostoProduccion { get; set; }

        public string TiempoPreparacion { get; set; } = string.Empty;

        public string UrlImagen { get; set; } = string.Empty;

        public bool Estado { get; set; }

        public DateTime FechaModificado { get; set; }

        public ICollection<Recetas> Recetas { get; set; } = new List<Recetas>();
    }
}
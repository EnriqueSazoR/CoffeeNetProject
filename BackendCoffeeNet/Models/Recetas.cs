using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendCoffeeNet.Models
{
    public class Recetas
    {
        [Key]
        public int Id_Receta { get; set; }

        public int Id_Producto { get; set; }
        [ForeignKey("Id_Producto")]
        public Productos Productos {get; set;} = null!;

        public int Id_insumos { get; set; }
        [ForeignKey("Id_insumos")]
        public Insumos Insumos {get; set;} = null!;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Cantidad_requerida { get; set; }

    }
}
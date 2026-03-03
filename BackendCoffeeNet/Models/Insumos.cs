using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendCoffeeNet.Models
{
    public class Insumos
    {
        [Key]
        public int Id_insumos { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Tipo { get; set; } = string.Empty;

        public string Unidad_medida { get; set; } = string.Empty;

        public decimal Stock_actual { get; set; }

        public decimal Stock_minimo { get; set; }

        public decimal Costo_unitario { get; set; }

        public int Id_Proveedor { get; set; }
        [ForeignKey("Id_Proveedor")]
        public Proveedores Proveedor { get; set; } = null!;

        public bool Estado { get; set; }

        public ICollection<Movimientos_Insumos> Movimientos_Insumos { get; set; } = new List<Movimientos_Insumos>();

        public ICollection<Recetas> Recetas { get; set; } = new List<Recetas>();
    }
}
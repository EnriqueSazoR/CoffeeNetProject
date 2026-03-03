using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendCoffeeNet.Models
{
    public class Movimientos_Insumos
    {
        [Key]
        public int Id_mov_insumos { get; set; }

        public int Id_insumos { get; set; }

        [ForeignKey("Id_insumos")]
        public Insumos Insumos { get; set; } = null!;

        public string Tipo_mov { get; set; } = string.Empty;

        public decimal Cantidad { get; set; }

        public decimal Stock_anterior { get; set; }

        public decimal Stock_nuevo { get; set; }

        public DateTime Fecha { get; set; }
    }
}
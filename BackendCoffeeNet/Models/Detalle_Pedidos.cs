using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendCoffeeNet.Models
{
    public class DetallePedidos
    {
        [Key]
        public int Id_DetallePedido { get; set; }

        // Llave foránea referncia a pedidos
        public int Id_Pedido { get; set; }
        [ForeignKey("Id_Pedido")]
        public Pedidos Pedidos {get; set;} = null!;

        // Llave foránea referencia a productos
        public int Id_Producto { get; set; }
        [ForeignKey("Id_Producto")]
        public Productos Productos {get; set;} = null!;

        public int Cantidad { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioUnitario { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Subtotal { get; set; }

        public string Comentario { get; set; } = string.Empty;


    }
}
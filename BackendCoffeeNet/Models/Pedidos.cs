using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendCoffeeNet.Models
{
    public class Pedidos
    {
        [Key]
        public int Id_Pedido { get; set; }

        // Llave foránea
        public int Id_Usuario { get; set; }
        [ForeignKey("Id_Usuario")]
        public Usuarios Usuarios {get; set;} = null!;

        public DateTime FechaPedido { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAPagar { get; set; }

        public string Estado { get; set; } = string.Empty;

        public string Comentario { get; set; } = string.Empty;
        

    }
}
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCoffeeNet.Migrations
{
    /// <inheritdoc />
    public partial class TblDetallePedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetallePedidos",
                columns: table => new
                {
                    Id_DetallePedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Pedido = table.Column<int>(type: "int", nullable: false),
                    Id_Producto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedidos", x => x.Id_DetallePedido);
                    table.ForeignKey(
                        name: "FK_DetallePedidos_Pedidos_Id_Pedido",
                        column: x => x.Id_Pedido,
                        principalTable: "Pedidos",
                        principalColumn: "Id_Pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallePedidos_Productos_Id_Producto",
                        column: x => x.Id_Producto,
                        principalTable: "Productos",
                        principalColumn: "Id_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidos_Id_Pedido",
                table: "DetallePedidos",
                column: "Id_Pedido");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidos_Id_Producto",
                table: "DetallePedidos",
                column: "Id_Producto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallePedidos");
        }
    }
}

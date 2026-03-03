using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendCoffeeNet.Migrations
{
    /// <inheritdoc />
    public partial class TblRecetas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    Id_Receta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Producto = table.Column<int>(type: "int", nullable: false),
                    Id_insumos = table.Column<int>(type: "int", nullable: false),
                    Cantidad_requerida = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.Id_Receta);
                    table.ForeignKey(
                        name: "FK_Recetas_Insumos_Id_insumos",
                        column: x => x.Id_insumos,
                        principalTable: "Insumos",
                        principalColumn: "Id_insumos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recetas_Productos_Id_Producto",
                        column: x => x.Id_Producto,
                        principalTable: "Productos",
                        principalColumn: "Id_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recetas_Id_insumos",
                table: "Recetas",
                column: "Id_insumos");

            migrationBuilder.CreateIndex(
                name: "IX_Recetas_Id_Producto",
                table: "Recetas",
                column: "Id_Producto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recetas");
        }
    }
}

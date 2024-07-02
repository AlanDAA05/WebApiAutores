using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAutores.Migrations
{
    /// <inheritdoc />
    public partial class Librerias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Librerias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Editorial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    libroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librerias", x => x.id);
                    table.ForeignKey(
                        name: "FK_Librerias_Libros_libroId",
                        column: x => x.libroId,
                        principalTable: "Libros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Librerias_libroId",
                table: "Librerias",
                column: "libroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Librerias");
        }
    }
}

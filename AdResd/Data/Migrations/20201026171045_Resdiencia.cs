using Microsoft.EntityFrameworkCore.Migrations;

namespace AdResd.Data.Migrations
{
    public partial class Resdiencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EncargadoPagos",
                columns: table => new
                {
                    IdEncargadoPago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEncargado = table.Column<string>(maxLength: 65, nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncargadoPagos", x => x.IdEncargadoPago);
                });

            migrationBuilder.CreateTable(
                name: "TipoResidencias",
                columns: table => new
                {
                    IdTipoResidencia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoResidencia = table.Column<string>(maxLength: 50, nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoResidencias", x => x.IdTipoResidencia);
                });

            migrationBuilder.CreateTable(
                name: "Residencias",
                columns: table => new
                {
                    IdResidencia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoResidenciaId = table.Column<int>(nullable: false),
                    NumeroDeResidencia = table.Column<string>(maxLength: 100, nullable: false),
                    CedulaDuenio = table.Column<string>(maxLength: 10, nullable: false),
                    NombresDuenio = table.Column<string>(maxLength: 70, nullable: false),
                    ApellidoDuenio = table.Column<string>(maxLength: 70, nullable: false),
                    TelefonoDuenio = table.Column<string>(maxLength: 10, nullable: false),
                    CorreoDuenio = table.Column<string>(nullable: true),
                    Arrendado = table.Column<bool>(nullable: false),
                    CedulaArrendatario = table.Column<string>(maxLength: 10, nullable: false),
                    NombreArrendatario = table.Column<string>(maxLength: 70, nullable: false),
                    ApellidoArrendatario = table.Column<string>(maxLength: 70, nullable: false),
                    TelefonoArrendatario = table.Column<string>(maxLength: 10, nullable: false),
                    EncargadoPagoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residencias", x => x.IdResidencia);
                    table.ForeignKey(
                        name: "FK_Residencias_EncargadoPagos_EncargadoPagoId",
                        column: x => x.EncargadoPagoId,
                        principalTable: "EncargadoPagos",
                        principalColumn: "IdEncargadoPago",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Residencias_TipoResidencias_TipoResidenciaId",
                        column: x => x.TipoResidenciaId,
                        principalTable: "TipoResidencias",
                        principalColumn: "IdTipoResidencia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Residencias_EncargadoPagoId",
                table: "Residencias",
                column: "EncargadoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Residencias_TipoResidenciaId",
                table: "Residencias",
                column: "TipoResidenciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Residencias");

            migrationBuilder.DropTable(
                name: "EncargadoPagos");

            migrationBuilder.DropTable(
                name: "TipoResidencias");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace EvTecnicaGyS.Migrations
{
    public partial class Migrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    CodCliente = table.Column<string>(type: "varchar(10)", nullable: false),
                    NombreCompleto = table.Column<string>(type: "varchar(200)", nullable: false),
                    NombreCorto = table.Column<string>(type: "varchar(40)", nullable: false),
                    Abreviatura = table.Column<string>(type: "varchar(40)", nullable: false),
                    Ruc = table.Column<string>(type: "varchar(11)", nullable: false),
                    Estado = table.Column<string>(type: "char(1)", nullable: false),
                    GrupoFacturacion = table.Column<string>(type: "varchar(100)", nullable: true),
                    InactivoDesde = table.Column<string>(type: "datetime", nullable: true),
                    CodigoSAP = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.CodCliente);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMK.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargueiros",
                columns: table => new
                {
                    CargueiroId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Espaco = table.Column<uint>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargueiros", x => x.CargueiroId);
                });

            migrationBuilder.CreateTable(
                name: "Minerios",
                columns: table => new
                {
                    MinerioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    PrecoPorKg = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Minerios", x => x.MinerioId);
                });

            migrationBuilder.CreateTable(
                name: "MinerioCargueiro",
                columns: table => new
                {
                    CargueiroId = table.Column<int>(type: "INTEGER", nullable: false),
                    MinerioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinerioCargueiro", x => new { x.MinerioId, x.CargueiroId });
                    table.ForeignKey(
                        name: "FK_MinerioCargueiro_Cargueiros_CargueiroId",
                        column: x => x.CargueiroId,
                        principalTable: "Cargueiros",
                        principalColumn: "CargueiroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MinerioCargueiro_Minerios_MinerioId",
                        column: x => x.MinerioId,
                        principalTable: "Minerios",
                        principalColumn: "MinerioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MinerioCargueiro_CargueiroId",
                table: "MinerioCargueiro",
                column: "CargueiroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MinerioCargueiro");

            migrationBuilder.DropTable(
                name: "Cargueiros");

            migrationBuilder.DropTable(
                name: "Minerios");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vipplussolution.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    saat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nereden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nereye = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yolcular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    acenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fiyat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turlar", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turlar");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kitapVerileri",
                columns: table => new
                {
                    kitap_no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    konu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    digerDetaylar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bekletmeDurmu = table.Column<int>(type: "int", nullable: false),
                    ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitapVerileri", x => x.kitap_no);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kitapVerileri");
        }
    }
}

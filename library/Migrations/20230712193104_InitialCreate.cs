using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    aliciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    alici_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kitap_no = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.aliciId);
                });

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
                    ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alıcıId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitapVerileri", x => x.kitap_no);
                });

            migrationBuilder.CreateTable(
                name: "Odunc",
                columns: table => new
                {
                    alıcıId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    alici_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kitap_no = table.Column<int>(type: "int", nullable: false),
                    OduncAlinmaZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odunc", x => x.alıcıId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kisiler");

            migrationBuilder.DropTable(
                name: "kitapVerileri");

            migrationBuilder.DropTable(
                name: "Odunc");
        }
    }
}

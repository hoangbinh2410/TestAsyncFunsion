using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ba_DemoAPI.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nhanvien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "char(20)", nullable: true),
                    Manv = table.Column<string>(type: "char(8)", nullable: true),
                    Diachi = table.Column<string>(type: "char(30)", nullable: true),
                    Gioitinh = table.Column<string>(type: "char(10)", nullable: true),
                    Ngaysinh = table.Column<DateTime>(type: "Date", nullable: false),
                    Phong = table.Column<string>(type: "char(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhanvien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Passwords",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passwords", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nhanvien");

            migrationBuilder.DropTable(
                name: "Passwords");
        }
    }
}

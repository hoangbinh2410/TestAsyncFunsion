using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ba_DemoAPI.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nhanvien",
                columns: new[] { "ID", "Diachi", "Gioitinh", "Manv", "Ngaysinh", "Phong", "Ten" },
                values: new object[,]
                {
                    { 1, "Bac Ninh", "Nam", "CT010304", new DateTime(1998, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "PM", "Hoang Tien Binh" },
                    { 2, "Thai Binh", "Nam", "CT010305", new DateTime(1998, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "PM", "Hoang Thanh Binh" },
                    { 3, "Bac Ninh", "Nu", "CT010306", new DateTime(1998, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "App", "Hoang Thi Binh" },
                    { 4, "Ha Noi", "Nu", "CT010307", new DateTime(1998, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mobile", "Nguyen Thi A" }
                });

            migrationBuilder.InsertData(
                table: "Passwords",
                columns: new[] { "ID", "Manv", "Pass", "User" },
                values: new object[,]
                {
                    { 1, "CT010304", "1234", "binhht2" },
                    { 2, "CT010305", "1234", "binhht1" },
                    { 3, "CT010306", "admin", "admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nhanvien",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nhanvien",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nhanvien",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nhanvien",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Passwords",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passwords",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Passwords",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}

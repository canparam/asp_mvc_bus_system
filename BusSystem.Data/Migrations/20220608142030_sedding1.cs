using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusSystem.Data.Migrations
{
    public partial class sedding1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62775cb9-5735-43b6-aaad-2857184039a4", "AQAAAAEAACcQAAAAEJtAn84LJIa2BUVtr4mPfVPaqqW1MDVVGIeQRDqd3E6sPX9RDpX8I260q8/HHjWMMQ==", "62e9bde8-73ca-4c21-82fc-e723ec0f59ae" });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1,
                column: "created_date",
                value: new DateTime(2022, 6, 8, 21, 20, 29, 594, DateTimeKind.Local).AddTicks(9008));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7b6db92-b0c0-471c-b3c1-b88e4b11de58", "AQAAAAEAACcQAAAAED1jtZUMlBLJJ6s8DueMSvfL/7sLoG5Wwy1W1yp9V733mFyywUwv82LJGj6p4RnmVQ==", null });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1,
                column: "created_date",
                value: new DateTime(2022, 6, 8, 21, 18, 14, 827, DateTimeKind.Local).AddTicks(4562));
        }
    }
}

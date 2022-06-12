using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusSystem.Data.Migrations
{
    public partial class v21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "502368fb-6758-4a1c-ac9a-662c56ab6824", "AQAAAAEAACcQAAAAEKDMHs4Jh+QcAAZI/sPHPeGkGOjm4pMIYZy0JtFB8Jnaw+9YXAIirf720sktbm/gRQ==", "e0f9e06a-5062-46d9-a1c3-a9bd95233cd7" });

            migrationBuilder.UpdateData(
                table: "Wallets",
                keyColumn: "id",
                keyValue: 1,
                column: "created_date",
                value: new DateTime(2022, 6, 9, 16, 8, 45, 649, DateTimeKind.Local).AddTicks(8562));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

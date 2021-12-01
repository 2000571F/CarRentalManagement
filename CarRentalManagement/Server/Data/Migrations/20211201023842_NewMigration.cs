using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 38, 42, 565, DateTimeKind.Local).AddTicks(6934), new DateTime(2021, 12, 1, 10, 38, 42, 567, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 38, 42, 568, DateTimeKind.Local).AddTicks(4871), new DateTime(2021, 12, 1, 10, 38, 42, 568, DateTimeKind.Local).AddTicks(4881) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 23, 29, 49, DateTimeKind.Local).AddTicks(9972), new DateTime(2021, 12, 1, 10, 23, 29, 50, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 23, 29, 50, DateTimeKind.Local).AddTicks(8374), new DateTime(2021, 12, 1, 10, 23, 29, 50, DateTimeKind.Local).AddTicks(8379) });
        }
    }
}

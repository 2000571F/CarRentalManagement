using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 46, 20, 729, DateTimeKind.Local).AddTicks(9231), new DateTime(2021, 12, 1, 10, 46, 20, 730, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 1, 10, 46, 20, 731, DateTimeKind.Local).AddTicks(823), new DateTime(2021, 12, 1, 10, 46, 20, 731, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 1, 10, 46, 20, 732, DateTimeKind.Local).AddTicks(5306), new DateTime(2021, 12, 1, 10, 46, 20, 732, DateTimeKind.Local).AddTicks(5315), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 12, 1, 10, 46, 20, 732, DateTimeKind.Local).AddTicks(5320), new DateTime(2021, 12, 1, 10, 46, 20, 732, DateTimeKind.Local).AddTicks(5321), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 1, 10, 46, 20, 732, DateTimeKind.Local).AddTicks(9831), new DateTime(2021, 12, 1, 10, 46, 20, 732, DateTimeKind.Local).AddTicks(9839), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 12, 1, 10, 46, 20, 732, DateTimeKind.Local).AddTicks(9844), new DateTime(2021, 12, 1, 10, 46, 20, 732, DateTimeKind.Local).AddTicks(9845), "X5", "System" },
                    { 3, "System", new DateTime(2021, 12, 1, 10, 46, 20, 732, DateTimeKind.Local).AddTicks(9847), new DateTime(2021, 12, 1, 10, 46, 20, 732, DateTimeKind.Local).AddTicks(9848), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 12, 1, 10, 46, 20, 732, DateTimeKind.Local).AddTicks(9850), new DateTime(2021, 12, 1, 10, 46, 20, 732, DateTimeKind.Local).AddTicks(9851), "Rav4", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

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
    }
}

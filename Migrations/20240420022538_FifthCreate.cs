using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HHPW.Migrations
{
    public partial class FifthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 17, 21, 25, 38, 218, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 18, 21, 25, 38, 220, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 19, 21, 25, 38, 220, DateTimeKind.Local).AddTicks(2634));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 17, 21, 22, 17, 674, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 4, 18, 21, 22, 17, 676, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 4, 19, 21, 22, 17, 676, DateTimeKind.Local).AddTicks(4964));
        }
    }
}

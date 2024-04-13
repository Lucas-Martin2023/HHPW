using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HHPW.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    Phone = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PaymentType = table.Column<string>(type: "text", nullable: false),
                    OrderType = table.Column<string>(type: "text", nullable: false),
                    Total = table.Column<int>(type: "integer", nullable: false),
                    Tip = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name", "price" },
                values: new object[,]
                {
                    { 1, "Widget", 10 },
                    { 2, "Gadget", 20 },
                    { 3, "Thingamajig", 15 },
                    { 4, "Doohickey", 25 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Date", "Email", "Name", "OrderType", "PaymentType", "Phone", "Status", "Tip", "Total", "userId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 11, 12, 2, 38, 291, DateTimeKind.Local).AddTicks(2002), "john@example.com", "John Doe", "Online", "Credit Card", 1234567890L, true, 5, 50, 1 },
                    { 2, new DateTime(2024, 4, 12, 12, 2, 38, 291, DateTimeKind.Local).AddTicks(2131), "jane@example.com", "Jane Smith", "In-store", "PayPal", 9876543210L, false, 3, 30, 2 },
                    { 3, new DateTime(2024, 4, 13, 12, 2, 38, 291, DateTimeKind.Local).AddTicks(2135), "alice@example.com", "Alice Johnson", "Delivery", "Cash", 5551234567L, true, 4, 45, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}

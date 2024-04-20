using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HHPW.Migrations
{
    public partial class seventhCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropTable(
                name: "ItemOrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Orders",
                newName: "IsOpen");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pizza");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Wangs");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Ands");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Thangs");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "OrderType", "PaymentType" },
                values: new object[] { new DateTime(2024, 4, 18, 2, 7, 3, 456, DateTimeKind.Local).AddTicks(4075), "Phone", "Check" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "OrderType", "PaymentType" },
                values: new object[] { new DateTime(2024, 4, 19, 2, 7, 3, 458, DateTimeKind.Local).AddTicks(5729), "In-Person", "Debit" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "OrderType" },
                values: new object[] { new DateTime(2024, 4, 20, 2, 7, 3, 458, DateTimeKind.Local).AddTicks(5764), "Phone" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ItemId",
                table: "OrderItems",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Items_ItemId",
                table: "OrderItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Items_ItemId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ItemId",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "IsOpen",
                table: "Orders",
                newName: "Status");

            migrationBuilder.CreateTable(
                name: "ItemOrderItem",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "integer", nullable: false),
                    OrdersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOrderItem", x => new { x.ItemsId, x.OrdersId });
                    table.ForeignKey(
                        name: "FK_ItemOrderItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemOrderItem_OrderItems_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "OrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Widget");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Gadget");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Thingamajig");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Doohickey");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "OrderType", "PaymentType" },
                values: new object[] { new DateTime(2024, 4, 17, 22, 38, 52, 517, DateTimeKind.Local).AddTicks(9759), "Online", "Credit Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "OrderType", "PaymentType" },
                values: new object[] { new DateTime(2024, 4, 18, 22, 38, 52, 519, DateTimeKind.Local).AddTicks(6506), "In-store", "PayPal" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "OrderType" },
                values: new object[] { new DateTime(2024, 4, 19, 22, 38, 52, 519, DateTimeKind.Local).AddTicks(6528), "Delivery" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrderItem_OrdersId",
                table: "ItemOrderItem",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

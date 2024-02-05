using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Context.Migrations
{
    /// <inheritdoc />
    public partial class makeItemNullableInproductcartandOrdercart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCartItems_Items_ItemID",
                table: "ProductCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrders_Items_itemID",
                table: "ProductInOrders");

            migrationBuilder.AlterColumn<int>(
                name: "itemID",
                table: "ProductInOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ItemID",
                table: "ProductCartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCartItems_Items_ItemID",
                table: "ProductCartItems",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrders_Items_itemID",
                table: "ProductInOrders",
                column: "itemID",
                principalTable: "Items",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCartItems_Items_ItemID",
                table: "ProductCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrders_Items_itemID",
                table: "ProductInOrders");

            migrationBuilder.AlterColumn<int>(
                name: "itemID",
                table: "ProductInOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemID",
                table: "ProductCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCartItems_Items_ItemID",
                table: "ProductCartItems",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrders_Items_itemID",
                table: "ProductInOrders",
                column: "itemID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

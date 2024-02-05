using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Context.Migrations
{
    /// <inheritdoc />
    public partial class changeInData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrders_Items_itemID",
                table: "ProductInOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrders_Products_productId",
                table: "ProductInOrders");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "ProductInOrders",
                newName: "product_Id");

            migrationBuilder.RenameColumn(
                name: "itemID",
                table: "ProductInOrders",
                newName: "item_ID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInOrders_productId",
                table: "ProductInOrders",
                newName: "IX_ProductInOrders_product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInOrders_itemID",
                table: "ProductInOrders",
                newName: "IX_ProductInOrders_item_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrders_Items_item_ID",
                table: "ProductInOrders",
                column: "item_ID",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrders_Products_product_Id",
                table: "ProductInOrders",
                column: "product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrders_Items_item_ID",
                table: "ProductInOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrders_Products_product_Id",
                table: "ProductInOrders");

            migrationBuilder.RenameColumn(
                name: "product_Id",
                table: "ProductInOrders",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "item_ID",
                table: "ProductInOrders",
                newName: "itemID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInOrders_product_Id",
                table: "ProductInOrders",
                newName: "IX_ProductInOrders_productId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInOrders_item_ID",
                table: "ProductInOrders",
                newName: "IX_ProductInOrders_itemID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrders_Items_itemID",
                table: "ProductInOrders",
                column: "itemID",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrders_Products_productId",
                table: "ProductInOrders",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

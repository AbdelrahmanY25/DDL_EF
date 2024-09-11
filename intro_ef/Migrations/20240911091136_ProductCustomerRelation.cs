using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace intro_ef.Migrations
{
    /// <inheritdoc />
    public partial class ProductCustomerRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Store",
                table: "Sales",
                newName: "StoreId");

            migrationBuilder.RenameColumn(
                name: "Product",
                table: "Sales",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Customer",
                table: "Sales",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "CustomerProduct",
                columns: table => new
                {
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProduct", x => new { x.CustomersId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProduct_ProductsId",
                table: "CustomerProduct",
                column: "ProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerProduct");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "Sales",
                newName: "Store");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Sales",
                newName: "Product");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Sales",
                newName: "Customer");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "CustomerId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Candyshop.Migrations
{
    public partial class TestOfDetailList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderDetailId1",
                table: "OrderDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderDetailId1",
                table: "OrderDetails",
                column: "OrderDetailId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderDetails_OrderDetailId1",
                table: "OrderDetails",
                column: "OrderDetailId1",
                principalTable: "OrderDetails",
                principalColumn: "OrderDetailId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderDetails_OrderDetailId1",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderDetailId1",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderDetailId1",
                table: "OrderDetails");
        }
    }
}

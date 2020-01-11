using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.MigrationHistory
{
    public partial class orderPizzaRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderList_LocationList_LocationIdentifierLocationID",
                table: "OrderList");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderList_UserList_UserInfoUserID",
                table: "OrderList");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaList_OrderList_OrderEntityOrderID",
                table: "PizzaList");

            migrationBuilder.DropIndex(
                name: "IX_PizzaList_OrderEntityOrderID",
                table: "PizzaList");

            migrationBuilder.DropIndex(
                name: "IX_OrderList_LocationIdentifierLocationID",
                table: "OrderList");

            migrationBuilder.DropIndex(
                name: "IX_OrderList_UserInfoUserID",
                table: "OrderList");

            migrationBuilder.DropColumn(
                name: "OrderEntityOrderID",
                table: "PizzaList");

            migrationBuilder.DropColumn(
                name: "LocationIdentifierLocationID",
                table: "OrderList");

            migrationBuilder.DropColumn(
                name: "UserInfoUserID",
                table: "OrderList");

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "PizzaList",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "OrderList",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "OrderList",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PizzaList_OrderID",
                table: "PizzaList",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderList_LocationID",
                table: "OrderList",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderList_UserID",
                table: "OrderList",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderList_LocationList_LocationID",
                table: "OrderList",
                column: "LocationID",
                principalTable: "LocationList",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderList_UserList_UserID",
                table: "OrderList",
                column: "UserID",
                principalTable: "UserList",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaList_OrderList_OrderID",
                table: "PizzaList",
                column: "OrderID",
                principalTable: "OrderList",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderList_LocationList_LocationID",
                table: "OrderList");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderList_UserList_UserID",
                table: "OrderList");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaList_OrderList_OrderID",
                table: "PizzaList");

            migrationBuilder.DropIndex(
                name: "IX_PizzaList_OrderID",
                table: "PizzaList");

            migrationBuilder.DropIndex(
                name: "IX_OrderList_LocationID",
                table: "OrderList");

            migrationBuilder.DropIndex(
                name: "IX_OrderList_UserID",
                table: "OrderList");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "PizzaList");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "OrderList");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "OrderList");

            migrationBuilder.AddColumn<int>(
                name: "OrderEntityOrderID",
                table: "PizzaList",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationIdentifierLocationID",
                table: "OrderList",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserInfoUserID",
                table: "OrderList",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PizzaList_OrderEntityOrderID",
                table: "PizzaList",
                column: "OrderEntityOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderList_LocationIdentifierLocationID",
                table: "OrderList",
                column: "LocationIdentifierLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderList_UserInfoUserID",
                table: "OrderList",
                column: "UserInfoUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderList_LocationList_LocationIdentifierLocationID",
                table: "OrderList",
                column: "LocationIdentifierLocationID",
                principalTable: "LocationList",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderList_UserList_UserInfoUserID",
                table: "OrderList",
                column: "UserInfoUserID",
                principalTable: "UserList",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaList_OrderList_OrderEntityOrderID",
                table: "PizzaList",
                column: "OrderEntityOrderID",
                principalTable: "OrderList",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

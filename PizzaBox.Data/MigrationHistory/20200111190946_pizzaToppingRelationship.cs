using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.MigrationHistory
{
    public partial class pizzaToppingRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaList_CrustList_PizzaCrustCrustID",
                table: "PizzaList");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaList_SizeList_PizzaSizeSizeID",
                table: "PizzaList");

            migrationBuilder.DropForeignKey(
                name: "FK_ToppingList_PizzaList_PizzaEntityPizzaID",
                table: "ToppingList");

            migrationBuilder.DropIndex(
                name: "IX_ToppingList_PizzaEntityPizzaID",
                table: "ToppingList");

            migrationBuilder.DropIndex(
                name: "IX_PizzaList_PizzaCrustCrustID",
                table: "PizzaList");

            migrationBuilder.DropIndex(
                name: "IX_PizzaList_PizzaSizeSizeID",
                table: "PizzaList");

            migrationBuilder.DropColumn(
                name: "PizzaEntityPizzaID",
                table: "ToppingList");

            migrationBuilder.DropColumn(
                name: "PizzaCrustCrustID",
                table: "PizzaList");

            migrationBuilder.DropColumn(
                name: "PizzaSizeSizeID",
                table: "PizzaList");

            migrationBuilder.AddColumn<int>(
                name: "PizzaID",
                table: "ToppingList",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CrustID",
                table: "PizzaList",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SizeID",
                table: "PizzaList",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ToppingList_PizzaID",
                table: "ToppingList",
                column: "PizzaID");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaList_CrustID",
                table: "PizzaList",
                column: "CrustID");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaList_SizeID",
                table: "PizzaList",
                column: "SizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaList_CrustList_CrustID",
                table: "PizzaList",
                column: "CrustID",
                principalTable: "CrustList",
                principalColumn: "CrustID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaList_SizeList_SizeID",
                table: "PizzaList",
                column: "SizeID",
                principalTable: "SizeList",
                principalColumn: "SizeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToppingList_PizzaList_PizzaID",
                table: "ToppingList",
                column: "PizzaID",
                principalTable: "PizzaList",
                principalColumn: "PizzaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaList_CrustList_CrustID",
                table: "PizzaList");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaList_SizeList_SizeID",
                table: "PizzaList");

            migrationBuilder.DropForeignKey(
                name: "FK_ToppingList_PizzaList_PizzaID",
                table: "ToppingList");

            migrationBuilder.DropIndex(
                name: "IX_ToppingList_PizzaID",
                table: "ToppingList");

            migrationBuilder.DropIndex(
                name: "IX_PizzaList_CrustID",
                table: "PizzaList");

            migrationBuilder.DropIndex(
                name: "IX_PizzaList_SizeID",
                table: "PizzaList");

            migrationBuilder.DropColumn(
                name: "PizzaID",
                table: "ToppingList");

            migrationBuilder.DropColumn(
                name: "CrustID",
                table: "PizzaList");

            migrationBuilder.DropColumn(
                name: "SizeID",
                table: "PizzaList");

            migrationBuilder.AddColumn<int>(
                name: "PizzaEntityPizzaID",
                table: "ToppingList",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PizzaCrustCrustID",
                table: "PizzaList",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PizzaSizeSizeID",
                table: "PizzaList",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToppingList_PizzaEntityPizzaID",
                table: "ToppingList",
                column: "PizzaEntityPizzaID");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaList_PizzaCrustCrustID",
                table: "PizzaList",
                column: "PizzaCrustCrustID");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaList_PizzaSizeSizeID",
                table: "PizzaList",
                column: "PizzaSizeSizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaList_CrustList_PizzaCrustCrustID",
                table: "PizzaList",
                column: "PizzaCrustCrustID",
                principalTable: "CrustList",
                principalColumn: "CrustID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaList_SizeList_PizzaSizeSizeID",
                table: "PizzaList",
                column: "PizzaSizeSizeID",
                principalTable: "SizeList",
                principalColumn: "SizeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ToppingList_PizzaList_PizzaEntityPizzaID",
                table: "ToppingList",
                column: "PizzaEntityPizzaID",
                principalTable: "PizzaList",
                principalColumn: "PizzaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

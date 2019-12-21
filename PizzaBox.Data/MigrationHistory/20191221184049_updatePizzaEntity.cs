using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.MigrationHistory
{
    public partial class updatePizzaEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaDefinition_CrustList_PizzaCrustCrustID",
                table: "PizzaDefinition");

            migrationBuilder.DropIndex(
                name: "IX_PizzaDefinition_PizzaCrustCrustID",
                table: "PizzaDefinition");

            migrationBuilder.DropColumn(
                name: "PizzaCrustCrustID",
                table: "PizzaDefinition");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PizzaCrustCrustID",
                table: "PizzaDefinition",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PizzaDefinition_PizzaCrustCrustID",
                table: "PizzaDefinition",
                column: "PizzaCrustCrustID");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaDefinition_CrustList_PizzaCrustCrustID",
                table: "PizzaDefinition",
                column: "PizzaCrustCrustID",
                principalTable: "CrustList",
                principalColumn: "CrustID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

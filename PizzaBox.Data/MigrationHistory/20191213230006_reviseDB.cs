using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.MigrationHistory
{
    public partial class reviseDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaList_CrustDefinition_PizzaCrustCrustID",
                table: "PizzaList");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaList_SizeDefinition_PizzaSizeSizeID",
                table: "PizzaList");

            migrationBuilder.DropForeignKey(
                name: "FK_ToppingDefinition_PizzaList_PizzaEntityPizzaID",
                table: "ToppingDefinition");

            migrationBuilder.DropIndex(
                name: "IX_ToppingDefinition_PizzaEntityPizzaID",
                table: "ToppingDefinition");

            migrationBuilder.DropColumn(
                name: "PizzaEntityPizzaID",
                table: "ToppingDefinition");

            migrationBuilder.RenameColumn(
                name: "ToppingID",
                table: "ToppingDefinition",
                newName: "ToppingDefID");

            migrationBuilder.RenameColumn(
                name: "SizeID",
                table: "SizeDefinition",
                newName: "SizeDefID");

            migrationBuilder.RenameColumn(
                name: "CrustID",
                table: "CrustDefinition",
                newName: "CrustDefID");

            migrationBuilder.CreateTable(
                name: "CrustList",
                columns: table => new
                {
                    CrustID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrustList", x => x.CrustID);
                });

            migrationBuilder.CreateTable(
                name: "SizeList",
                columns: table => new
                {
                    SizeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeList", x => x.SizeID);
                });

            migrationBuilder.CreateTable(
                name: "ToppingList",
                columns: table => new
                {
                    ToppingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PizzaEntityPizzaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToppingList", x => x.ToppingID);
                    table.ForeignKey(
                        name: "FK_ToppingList_PizzaList_PizzaEntityPizzaID",
                        column: x => x.PizzaEntityPizzaID,
                        principalTable: "PizzaList",
                        principalColumn: "PizzaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PizzaDefinition",
                columns: table => new
                {
                    StorePizzaDefID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PizzaCrustCrustID = table.Column<int>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaDefinition", x => x.StorePizzaDefID);
                    table.ForeignKey(
                        name: "FK_PizzaDefinition_CrustList_PizzaCrustCrustID",
                        column: x => x.PizzaCrustCrustID,
                        principalTable: "CrustList",
                        principalColumn: "CrustID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PizzaDefinition_PizzaCrustCrustID",
                table: "PizzaDefinition",
                column: "PizzaCrustCrustID");

            migrationBuilder.CreateIndex(
                name: "IX_ToppingList_PizzaEntityPizzaID",
                table: "ToppingList",
                column: "PizzaEntityPizzaID");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaList_CrustList_PizzaCrustCrustID",
                table: "PizzaList");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaList_SizeList_PizzaSizeSizeID",
                table: "PizzaList");

            migrationBuilder.DropTable(
                name: "PizzaDefinition");

            migrationBuilder.DropTable(
                name: "SizeList");

            migrationBuilder.DropTable(
                name: "ToppingList");

            migrationBuilder.DropTable(
                name: "CrustList");

            migrationBuilder.RenameColumn(
                name: "ToppingDefID",
                table: "ToppingDefinition",
                newName: "ToppingID");

            migrationBuilder.RenameColumn(
                name: "SizeDefID",
                table: "SizeDefinition",
                newName: "SizeID");

            migrationBuilder.RenameColumn(
                name: "CrustDefID",
                table: "CrustDefinition",
                newName: "CrustID");

            migrationBuilder.AddColumn<int>(
                name: "PizzaEntityPizzaID",
                table: "ToppingDefinition",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToppingDefinition_PizzaEntityPizzaID",
                table: "ToppingDefinition",
                column: "PizzaEntityPizzaID");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaList_CrustDefinition_PizzaCrustCrustID",
                table: "PizzaList",
                column: "PizzaCrustCrustID",
                principalTable: "CrustDefinition",
                principalColumn: "CrustID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaList_SizeDefinition_PizzaSizeSizeID",
                table: "PizzaList",
                column: "PizzaSizeSizeID",
                principalTable: "SizeDefinition",
                principalColumn: "SizeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ToppingDefinition_PizzaList_PizzaEntityPizzaID",
                table: "ToppingDefinition",
                column: "PizzaEntityPizzaID",
                principalTable: "PizzaList",
                principalColumn: "PizzaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

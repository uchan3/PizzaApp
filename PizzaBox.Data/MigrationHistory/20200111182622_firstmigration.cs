using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.MigrationHistory
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrustDefinition",
                columns: table => new
                {
                    CrustDefID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrustDefinition", x => x.CrustDefID);
                });

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
                name: "LocationList",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationList", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "PizzaDefinition",
                columns: table => new
                {
                    StorePizzaDefID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaDefinition", x => x.StorePizzaDefID);
                });

            migrationBuilder.CreateTable(
                name: "SizeDefinition",
                columns: table => new
                {
                    SizeDefID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeDefinition", x => x.SizeDefID);
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
                name: "ToppingDefinition",
                columns: table => new
                {
                    ToppingDefID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToppingDefinition", x => x.ToppingDefID);
                });

            migrationBuilder.CreateTable(
                name: "UserList",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserList", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "OrderList",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserInfoUserID = table.Column<int>(nullable: true),
                    LocationIdentifierLocationID = table.Column<int>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderList", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_OrderList_LocationList_LocationIdentifierLocationID",
                        column: x => x.LocationIdentifierLocationID,
                        principalTable: "LocationList",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderList_UserList_UserInfoUserID",
                        column: x => x.UserInfoUserID,
                        principalTable: "UserList",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PizzaList",
                columns: table => new
                {
                    PizzaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PizzaSizeSizeID = table.Column<int>(nullable: true),
                    PizzaCrustCrustID = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    OrderEntityOrderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaList", x => x.PizzaID);
                    table.ForeignKey(
                        name: "FK_PizzaList_OrderList_OrderEntityOrderID",
                        column: x => x.OrderEntityOrderID,
                        principalTable: "OrderList",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PizzaList_CrustList_PizzaCrustCrustID",
                        column: x => x.PizzaCrustCrustID,
                        principalTable: "CrustList",
                        principalColumn: "CrustID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PizzaList_SizeList_PizzaSizeSizeID",
                        column: x => x.PizzaSizeSizeID,
                        principalTable: "SizeList",
                        principalColumn: "SizeID",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateIndex(
                name: "IX_OrderList_LocationIdentifierLocationID",
                table: "OrderList",
                column: "LocationIdentifierLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderList_UserInfoUserID",
                table: "OrderList",
                column: "UserInfoUserID");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaList_OrderEntityOrderID",
                table: "PizzaList",
                column: "OrderEntityOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaList_PizzaCrustCrustID",
                table: "PizzaList",
                column: "PizzaCrustCrustID");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaList_PizzaSizeSizeID",
                table: "PizzaList",
                column: "PizzaSizeSizeID");

            migrationBuilder.CreateIndex(
                name: "IX_ToppingList_PizzaEntityPizzaID",
                table: "ToppingList",
                column: "PizzaEntityPizzaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrustDefinition");

            migrationBuilder.DropTable(
                name: "PizzaDefinition");

            migrationBuilder.DropTable(
                name: "SizeDefinition");

            migrationBuilder.DropTable(
                name: "ToppingDefinition");

            migrationBuilder.DropTable(
                name: "ToppingList");

            migrationBuilder.DropTable(
                name: "PizzaList");

            migrationBuilder.DropTable(
                name: "OrderList");

            migrationBuilder.DropTable(
                name: "CrustList");

            migrationBuilder.DropTable(
                name: "SizeList");

            migrationBuilder.DropTable(
                name: "LocationList");

            migrationBuilder.DropTable(
                name: "UserList");
        }
    }
}

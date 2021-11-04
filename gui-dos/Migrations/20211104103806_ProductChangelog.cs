using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gui_dos.Migrations
{
    public partial class ProductChangelog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "changes");

            migrationBuilder.DropTable(
                name: "giftbaskets");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "orders",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Deadline",
                table: "orders",
                newName: "DateDeadline");

            migrationBuilder.AddColumn<string>(
                name: "Changelog",
                table: "products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Changelog",
                table: "orders",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "orders",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GiftBaskets",
                table: "orders",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Changelog",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Changelog",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "GiftBaskets",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "orders",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DateDeadline",
                table: "orders",
                newName: "Deadline");

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsOwner = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    Username = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "giftbaskets",
                columns: table => new
                {
                    GiftBasketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: true),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_giftbaskets", x => x.GiftBasketId);
                    table.ForeignKey(
                        name: "FK_giftbaskets_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_giftbaskets_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "changes",
                columns: table => new
                {
                    ChangeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChangeMade = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_changes", x => x.ChangeId);
                    table.ForeignKey(
                        name: "FK_changes_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_changes_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_changes_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_changes_EmployeeId",
                table: "changes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_changes_OrderId",
                table: "changes",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_changes_ProductId",
                table: "changes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_giftbaskets_OrderId",
                table: "giftbaskets",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_giftbaskets_ProductId",
                table: "giftbaskets",
                column: "ProductId");
        }
    }
}

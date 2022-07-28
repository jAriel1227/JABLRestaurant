using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestauranteAPI.Infrastructure.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "RestaurantAPI");

            migrationBuilder.CreateTable(
                name: "OrdersStatus",
                schema: "RestaurantAPI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlatesCategory",
                schema: "RestaurantAPI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatesCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablesStatus",
                schema: "RestaurantAPI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablesStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "RestaurantAPI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPlates = table.Column<int>(type: "int", nullable: false),
                    SubTotal = table.Column<bool>(type: "bit", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_OrdersStatus_StateId",
                        column: x => x.StateId,
                        principalSchema: "RestaurantAPI",
                        principalTable: "OrdersStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                schema: "RestaurantAPI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numberofpeople = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tables_TablesStatus_StateId",
                        column: x => x.StateId,
                        principalSchema: "RestaurantAPI",
                        principalTable: "TablesStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plates",
                schema: "RestaurantAPI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlatePrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    givePeple = table.Column<int>(type: "int", nullable: false),
                    IdCategory = table.Column<int>(type: "int", nullable: false),
                    IdOrders = table.Column<int>(type: "int", nullable: false),
                    PlatesIngredientsId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plates_Orders_IdOrders",
                        column: x => x.IdOrders,
                        principalSchema: "RestaurantAPI",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plates_Plates_PlatesIngredientsId",
                        column: x => x.PlatesIngredientsId,
                        principalSchema: "RestaurantAPI",
                        principalTable: "Plates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plates_PlatesCategory_IdCategory",
                        column: x => x.IdCategory,
                        principalSchema: "RestaurantAPI",
                        principalTable: "PlatesCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                schema: "RestaurantAPI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlateId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Plates_PlateId",
                        column: x => x.PlateId,
                        principalSchema: "RestaurantAPI",
                        principalTable: "Plates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "RestaurantAPI",
                table: "OrdersStatus",
                columns: new[] { "Id", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 28, 1, 18, 37, 656, DateTimeKind.Local).AddTicks(2486), "DefaultDatabaseAdministrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "In process" },
                    { 2, new DateTime(2022, 7, 28, 1, 18, 37, 658, DateTimeKind.Local).AddTicks(7204), "DefaultDatabaseAdministrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Completed" }
                });

            migrationBuilder.InsertData(
                schema: "RestaurantAPI",
                table: "PlatesCategory",
                columns: new[] { "Id", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 28, 1, 18, 37, 661, DateTimeKind.Local).AddTicks(8482), "DefaultDatabaseAdministrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Entry" },
                    { 2, new DateTime(2022, 7, 28, 1, 18, 37, 661, DateTimeKind.Local).AddTicks(8518), "DefaultDatabaseAdministrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Main course" },
                    { 3, new DateTime(2022, 7, 28, 1, 18, 37, 661, DateTimeKind.Local).AddTicks(8526), "DefaultDatabaseAdministrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Dessert" },
                    { 4, new DateTime(2022, 7, 28, 1, 18, 37, 661, DateTimeKind.Local).AddTicks(8533), "DefaultDatabaseAdministrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beverage" }
                });

            migrationBuilder.InsertData(
                schema: "RestaurantAPI",
                table: "TablesStatus",
                columns: new[] { "Id", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 28, 1, 18, 37, 662, DateTimeKind.Local).AddTicks(995), "DefaultDatabaseAdministrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Available" },
                    { 2, new DateTime(2022, 7, 28, 1, 18, 37, 662, DateTimeKind.Local).AddTicks(1015), "DefaultDatabaseAdministrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "In care process" },
                    { 3, new DateTime(2022, 7, 28, 1, 18, 37, 662, DateTimeKind.Local).AddTicks(1021), "DefaultDatabaseAdministrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Serviced" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_PlateId",
                schema: "RestaurantAPI",
                table: "Ingredients",
                column: "PlateId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StateId",
                schema: "RestaurantAPI",
                table: "Orders",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Plates_IdCategory",
                schema: "RestaurantAPI",
                table: "Plates",
                column: "IdCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Plates_IdOrders",
                schema: "RestaurantAPI",
                table: "Plates",
                column: "IdOrders");

            migrationBuilder.CreateIndex(
                name: "IX_Plates_PlatesIngredientsId",
                schema: "RestaurantAPI",
                table: "Plates",
                column: "PlatesIngredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_StateId",
                schema: "RestaurantAPI",
                table: "Tables",
                column: "StateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients",
                schema: "RestaurantAPI");

            migrationBuilder.DropTable(
                name: "Tables",
                schema: "RestaurantAPI");

            migrationBuilder.DropTable(
                name: "Plates",
                schema: "RestaurantAPI");

            migrationBuilder.DropTable(
                name: "TablesStatus",
                schema: "RestaurantAPI");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "RestaurantAPI");

            migrationBuilder.DropTable(
                name: "PlatesCategory",
                schema: "RestaurantAPI");

            migrationBuilder.DropTable(
                name: "OrdersStatus",
                schema: "RestaurantAPI");
        }
    }
}

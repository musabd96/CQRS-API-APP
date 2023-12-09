using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnimals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Birds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LikesToPlay = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birds", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LikesToPlay = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LikesToPlay = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("01859fba-5ba5-46ac-8ca9-d5d3d46cacf4"), true, "Alex" },
                    { new Guid("12345678-1234-5678-1234-567812345670"), true, "TestCatForUnitTests" },
                    { new Guid("12345678-1234-5678-1234-567812345671"), true, "TestCatForUnitTests" },
                    { new Guid("12345678-1234-5678-1234-567812345678"), true, "TestCatForUnitTests" },
                    { new Guid("35bf024b-c32e-4b31-a6e2-c0e380cc9687"), true, "Sofia" },
                    { new Guid("febb0644-b1a1-4a00-8475-031de8c804db"), true, "Max" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("12345678-1234-5678-1234-567812345670"), true, "TestCatForUnitTests" },
                    { new Guid("12345678-1234-5678-1234-567812345671"), true, "TestCatForUnitTests" },
                    { new Guid("12345678-1234-5678-1234-567812345678"), true, "TestCatForUnitTests" },
                    { new Guid("2a3afce9-9b7a-4f9f-a35a-70696d102b75"), true, "Nelson" },
                    { new Guid("4e4d7f8d-3a40-406c-86d3-c6bd8ecf1409"), true, "Alpin" },
                    { new Guid("832b4c46-0526-427f-a5b4-6abc7da249a8"), true, "Steven" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("08ed2ab4-1e22-4278-b388-b20a467b2b7a"), true, "Björn" },
                    { new Guid("12345678-1234-5678-1234-567812345670"), true, "TestDogForUnitTests" },
                    { new Guid("12345678-1234-5678-1234-567812345671"), true, "TestDogForUnitTests" },
                    { new Guid("12345678-1234-5678-1234-567812345678"), true, "TestDogForUnitTests" },
                    { new Guid("586f8b42-7222-4afd-a9aa-fcfe2e22740c"), true, "Alfred" },
                    { new Guid("d8626e6f-b081-4e5a-bad0-31ef15ffe272"), true, "Patrik" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Birds");

            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

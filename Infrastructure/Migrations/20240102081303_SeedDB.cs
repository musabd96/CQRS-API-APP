using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDB : Migration
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
                    TypeOfAnimal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    animalCanDo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LikesToPlay = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Color = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    TypeOfAnimal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    animalCanDo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LikesToPlay = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Breed = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Weight = table.Column<int>(type: "int", nullable: false)
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
                    TypeOfAnimal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    animalCanDo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LikesToPlay = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Breed = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Weight = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "UserBird",
                columns: table => new
                {
                    BirdId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBird", x => new { x.BirdId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserBird_Birds_BirdId",
                        column: x => x.BirdId,
                        principalTable: "Birds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBird_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserCat",
                columns: table => new
                {
                    CatId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCat", x => new { x.CatId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserCat_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCat_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserDog",
                columns: table => new
                {
                    DogId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDog", x => new { x.DogId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserDog_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDog_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "Color", "LikesToPlay", "Name", "TypeOfAnimal", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("08791458-cc5b-4ac8-84ff-506522eabab0"), "Blue", true, "Sky", "Bird", "This animal can fly" },
                    { new Guid("54097f99-9f1e-4cf1-9426-28c17cea3d8d"), "Green", true, "Kiwi", "Bird", "This animal can fly" },
                    { new Guid("5fd24364-3717-4ec3-9f29-4f978f92b1ea"), "White", true, "Snowflake", "Bird", "This animal can fly" },
                    { new Guid("6b8d1acc-a1b3-4d02-beb3-ad3a56ef0ca3"), "Yellow", true, "Sunshine", "Bird", "This animal can fly" },
                    { new Guid("8bafca12-b72d-43c1-a3d3-50f2780352fa"), "Red", true, "Cherry", "Bird", "This animal can fly" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "TypeOfAnimal", "Weight", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("25e28904-58fc-4e75-a96a-30243ec0edf6"), "Bengal", true, "Tiger", "Cat", 11, "This animal can meow" },
                    { new Guid("3c53d2f5-d8ea-4a87-83c0-c0dc467f914c"), "Persian", true, "Mittens", "Cat", 10, "This animal can meow" },
                    { new Guid("598f503e-d116-4095-bbfb-fd9ed23ddc10"), "Siamese", true, "Whiskers", "Cat", 8, "This animal can meow" },
                    { new Guid("76c94b8f-b193-4286-9fc9-7e805a127a57"), "Ragdoll", true, "Smokey", "Cat", 12, "This animal can meow" },
                    { new Guid("dc606026-5ad3-49a7-b7cb-1e6c39cb8ba7"), "Maine Coon", true, "Shadow", "Cat", 15, "This animal can meow" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "TypeOfAnimal", "Weight", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("1dad1320-01bb-472a-a7da-d738bd6853ad"), "Golden Retriever", true, "Riley", "Dog", 30, "This animal can bark" },
                    { new Guid("94327f69-ab69-4ff8-9e4b-e1ceeaffbe5b"), "Labrador", true, "Luna", "Dog", 25, "This animal can bark" },
                    { new Guid("9d191bfb-a6a8-4ad7-9439-bf16d806f81b"), "Beagle", true, "Daisy", "Dog", 18, "This animal can bark" },
                    { new Guid("c8cb8a74-1ebc-409f-b4e9-a9fc8be871b1"), "Poodle", true, "Rocky", "Dog", 15, "This animal can bark" },
                    { new Guid("edd86ee3-07c3-4604-83af-1bd5d8b298d7"), "German Shepherd", true, "Bella", "Dog", 30, "This animal can bark" },
                    { new Guid("fbef7972-936d-49e7-83a5-c4babfd88320"), "Golden Retriever", true, "Max", "Dog", 28, "This animal can bark" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("852a120a-942e-4dd7-9cfb-36b0ae3dce54"), "$2a$11$ZsrpBR751ruSt690a/M0j.1mNU.G9xPh/ideUXK.YAziDR3VUPjZC", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_UserBird_UserId",
                table: "UserBird",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCat_UserId",
                table: "UserCat",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDog_UserId",
                table: "UserDog",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBird");

            migrationBuilder.DropTable(
                name: "UserCat");

            migrationBuilder.DropTable(
                name: "UserDog");

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

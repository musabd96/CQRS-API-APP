using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeadAnimalUpdate : Migration
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
                    { new Guid("24cc2a8d-4c11-4216-b6eb-8508a35d5262"), "White", true, "Snowflake", "Bird", "This animal can fly" },
                    { new Guid("3bf8699a-cff9-4231-9cc6-a2669418a10c"), "Yellow", true, "Sunshine", "Bird", "This animal can fly" },
                    { new Guid("755efddb-afec-48d8-8977-0494741aaa9e"), "Red", true, "Cherry", "Bird", "This animal can fly" },
                    { new Guid("c7b66443-e962-4ffc-93e6-91995023b16f"), "Blue", true, "Sky", "Bird", "This animal can fly" },
                    { new Guid("db156db9-9253-412a-bb8f-a2e44c3e2d7f"), "Green", true, "Kiwi", "Bird", "This animal can fly" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "TypeOfAnimal", "Weight", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("13537654-700b-47ca-98d0-e31e22bf6bb6"), "Ragdoll", true, "Smokey", "Cat", 12, "This animal can meow" },
                    { new Guid("7279e1c1-9dc9-4787-93d7-e2572f7811eb"), "Persian", true, "Mittens", "Cat", 10, "This animal can meow" },
                    { new Guid("9d53e078-f54b-48a9-ad15-4dd456f56079"), "Bengal", true, "Tiger", "Cat", 11, "This animal can meow" },
                    { new Guid("c197b233-3249-48eb-b016-74ba090ba989"), "Maine Coon", true, "Shadow", "Cat", 15, "This animal can meow" },
                    { new Guid("c2acbc1b-7fdc-4e2e-92be-8a2a2336168e"), "Siamese", true, "Whiskers", "Cat", 8, "This animal can meow" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "TypeOfAnimal", "Weight", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("4779a5c5-9ede-4d35-ae98-bf552a650d3b"), "Beagle", true, "Daisy", "Dog", 18, "This animal can bark" },
                    { new Guid("4a843d7a-1eca-449c-8d7c-ba5f168ebf35"), "German Shepherd", true, "Bella", "Dog", 30, "This animal can bark" },
                    { new Guid("a79ab4c5-a5e8-4404-87f9-bf3c15cce925"), "Golden Retriever", true, "Riley", "Dog", 30, "This animal can bark" },
                    { new Guid("c48537b3-3aab-4503-bf67-1c197c076ac3"), "Labrador", true, "Luna", "Dog", 25, "This animal can bark" },
                    { new Guid("cc756eca-7302-4ffa-9c5a-d354b9f76ca1"), "Golden Retriever", true, "Max", "Dog", 28, "This animal can bark" },
                    { new Guid("e59de086-1975-4c19-9efe-f38c075bb74b"), "Poodle", true, "Rocky", "Dog", 15, "This animal can bark" }
                });

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

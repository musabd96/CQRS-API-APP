using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedBreedDogAndCat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("5d1efa42-8167-490c-bc07-2bd58533422d"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("6896c286-5c6a-410c-890b-bc545f5abf95"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("fe1e729f-5f16-4ea2-b4d6-c222243ff7f2"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("5cc357e5-8c47-4f93-b187-ff525ad0ad7a"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("5f12b18d-6eb7-493c-b45e-183cb0e51664"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("779afd2b-e15b-4ff3-8031-1c2ad640fd1d"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("7b5dd4f5-c8d3-4b98-a824-b04d3267d4ea"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("cd581596-8954-430b-bc0a-25f559392794"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("f671a50c-029f-4af1-a1d8-fb2baad286b3"));

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "Dogs",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "Cats",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "Birds",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("427af8ea-c3f2-41dd-909c-e5adc46f5f21"), "", true, "Alex" },
                    { new Guid("61b1cc37-1746-4407-9ace-deabd55afeac"), "", true, "Sofia" },
                    { new Guid("bb45d76f-64dc-4e40-8fb1-7e0a5bae9fa4"), "", true, "Max" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("1e95ff9b-04ad-4de0-91c2-9d171733d50f"), "Siamese", true, "Steven" },
                    { new Guid("474a171b-1595-4f20-809b-aaf13249a3e9"), "Maine Coon", true, "Nelson" },
                    { new Guid("c739c729-d572-41dd-855b-ecb72eb7f1a2"), "Persian", true, "Alpin" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("12d7c360-1764-4ebc-994e-182f2a458f53"), "German Shepherd", true, "Alfred" },
                    { new Guid("4656edda-5908-4575-9dcc-9625775116f0"), "Labrador", true, "Björn" },
                    { new Guid("5372d336-b199-40c1-8ec8-d67d23b50274"), "Golden Retriever", true, "Patrik" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("427af8ea-c3f2-41dd-909c-e5adc46f5f21"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("61b1cc37-1746-4407-9ace-deabd55afeac"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("bb45d76f-64dc-4e40-8fb1-7e0a5bae9fa4"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("1e95ff9b-04ad-4de0-91c2-9d171733d50f"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("474a171b-1595-4f20-809b-aaf13249a3e9"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("c739c729-d572-41dd-855b-ecb72eb7f1a2"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("12d7c360-1764-4ebc-994e-182f2a458f53"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("4656edda-5908-4575-9dcc-9625775116f0"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("5372d336-b199-40c1-8ec8-d67d23b50274"));

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Birds");

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("5d1efa42-8167-490c-bc07-2bd58533422d"), true, "Max" },
                    { new Guid("6896c286-5c6a-410c-890b-bc545f5abf95"), true, "Alex" },
                    { new Guid("fe1e729f-5f16-4ea2-b4d6-c222243ff7f2"), true, "Sofia" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("5cc357e5-8c47-4f93-b187-ff525ad0ad7a"), true, "Nelson" },
                    { new Guid("5f12b18d-6eb7-493c-b45e-183cb0e51664"), true, "Steven" },
                    { new Guid("779afd2b-e15b-4ff3-8031-1c2ad640fd1d"), true, "Alpin" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("7b5dd4f5-c8d3-4b98-a824-b04d3267d4ea"), true, "Patrik" },
                    { new Guid("cd581596-8954-430b-bc0a-25f559392794"), true, "Alfred" },
                    { new Guid("f671a50c-029f-4af1-a1d8-fb2baad286b3"), true, "Björn" }
                });
        }
    }
}

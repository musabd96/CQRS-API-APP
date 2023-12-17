using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeadAnimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "Color", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("23e09afa-ff7e-49bf-83da-500848e6760c"), "Yellow", true, "Sunshine" },
                    { new Guid("73a50dc3-967e-480f-be01-1ced8ad6b999"), "Blue", true, "Sky" },
                    { new Guid("802a5917-a6f9-4275-8d62-12e8da00e6cf"), "Red", true, "Cherry" },
                    { new Guid("91fe78b0-8c74-4590-9dad-7e03e5a9c100"), "Green", true, "Kiwi" },
                    { new Guid("e4c917ea-505b-4a9f-bf82-416718c60ec0"), "White", true, "Snowflake" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("33b32911-b1d6-49c5-9a81-24f4966c726b"), "Ragdoll", true, "Smokey", 12 },
                    { new Guid("5755190b-9cad-4d29-94dc-b579c6cbbffa"), "Bengal", true, "Tiger", 11 },
                    { new Guid("6a57904f-57be-440b-85ac-f83d4a98555a"), "Persian", true, "Mittens", 10 },
                    { new Guid("7bca437b-87f8-4723-a412-c4a0cf89d01d"), "Maine Coon", true, "Shadow", 15 },
                    { new Guid("a722f242-fb7c-46dd-888f-24dee483b99d"), "Siamese", true, "Whiskers", 8 }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("2cfe4516-598b-4526-9355-5634e140869f"), "Golden Retriever", true, "Max", 28 },
                    { new Guid("625a85d2-9109-4c31-84de-88543dc37a37"), "Poodle", true, "Rocky", 15 },
                    { new Guid("694f492d-032e-4324-8ed8-9e42f8c5c8a7"), "German Shepherd", true, "Bella", 30 },
                    { new Guid("b6ba1578-cc05-4342-aef1-5926e6f91f59"), "Labrador", true, "Luna", 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("23e09afa-ff7e-49bf-83da-500848e6760c"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("73a50dc3-967e-480f-be01-1ced8ad6b999"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("802a5917-a6f9-4275-8d62-12e8da00e6cf"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("91fe78b0-8c74-4590-9dad-7e03e5a9c100"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("e4c917ea-505b-4a9f-bf82-416718c60ec0"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("33b32911-b1d6-49c5-9a81-24f4966c726b"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("5755190b-9cad-4d29-94dc-b579c6cbbffa"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("6a57904f-57be-440b-85ac-f83d4a98555a"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("7bca437b-87f8-4723-a412-c4a0cf89d01d"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("a722f242-fb7c-46dd-888f-24dee483b99d"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("2cfe4516-598b-4526-9355-5634e140869f"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("625a85d2-9109-4c31-84de-88543dc37a37"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("694f492d-032e-4324-8ed8-9e42f8c5c8a7"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("b6ba1578-cc05-4342-aef1-5926e6f91f59"));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeadAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("007dd11d-8618-479f-96f9-d4dedd91282d"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("20421861-45c8-4c73-a9d3-86d298591e3d"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("29183377-ff6e-4ba1-a0b9-7f90faf85961"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("73399501-7256-4bd3-b2c1-5fd13da28602"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("a982bf15-f1c9-47fc-97cb-cef2e5940c7e"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("03862852-72f2-42e0-90d4-3197a507fe30"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("7281eb31-94ae-4e94-8d77-80a07c928001"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("7d564f19-0f18-41ee-98aa-4d5c395cbea7"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d0adcbc7-b9b5-4145-aec7-b70124454f1e"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d86fdb16-7885-495b-8d20-997ffe5da528"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("165bfa21-b3ce-4810-962a-ab98f70c369f"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("a0e4df16-14db-4679-8278-d045d2554525"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("b04dc8bf-7285-461c-9ba7-7eed3c8b0ba6"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("ba2918a9-89d8-4941-85ee-20680fca43f0"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("ed2fb8ad-d5c5-42af-8acd-aadd8dcad39b"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("f76e4ed8-dad7-4f72-bf78-d85e89f437c7"));

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "Color", "LikesToPlay", "Name", "TypeOfAnimal", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("0abfd852-25f9-4bbb-84a3-8842e5ee0475"), "Green", true, "Kiwi", "Bird", "This animal can fly" },
                    { new Guid("0cd93c3f-66e5-4392-8980-cccc07dda003"), "Blue", true, "Sky", "Bird", "This animal can fly" },
                    { new Guid("12223ef9-03b8-44d5-9801-5570fc79b5b4"), "Yellow", true, "Sunshine", "Bird", "This animal can fly" },
                    { new Guid("7f10ba7d-d81b-445d-a1e9-0b4d1ba63441"), "White", true, "Snowflake", "Bird", "This animal can fly" },
                    { new Guid("94572362-3c86-4777-b990-514f0ff85135"), "Red", true, "Cherry", "Bird", "This animal can fly" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "TypeOfAnimal", "Weight", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("2f55c8c0-7cc0-4d28-b666-fce48b2ec835"), "Maine Coon", true, "Shadow", "Cat", 15, "This animal can meow" },
                    { new Guid("30f2d255-cedc-491f-b7e0-d48f3e36504f"), "Persian", true, "Mittens", "Cat", 10, "This animal can meow" },
                    { new Guid("a0c15204-7700-4d23-816a-a0d8081ee01f"), "Ragdoll", true, "Smokey", "Cat", 12, "This animal can meow" },
                    { new Guid("afb9ffa5-dd75-4114-a237-5a8c4b36cd65"), "Siamese", true, "Whiskers", "Cat", 8, "This animal can meow" },
                    { new Guid("d7b5f156-4159-4cba-a632-aedfe31980cd"), "Bengal", true, "Tiger", "Cat", 11, "This animal can meow" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "TypeOfAnimal", "Weight", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("0c3ce72e-dcad-4622-be37-211105d3787c"), "German Shepherd", true, "Bella", "Dog", 30, "This animal can bark" },
                    { new Guid("40dc7260-e136-4f4c-980b-970057c3ab8e"), "Labrador", true, "Luna", "Dog", 25, "This animal can bark" },
                    { new Guid("5e9ecac1-d1d4-4742-8fa0-d770cd866285"), "Beagle", true, "Daisy", "Dog", 18, "This animal can bark" },
                    { new Guid("a4c56d9e-f867-4297-aae7-5d13eb4d404f"), "Golden Retriever", true, "Max", "Dog", 28, "This animal can bark" },
                    { new Guid("f851acbe-935c-4137-a020-7aea7b7a7539"), "Golden Retriever", true, "Riley", "Dog", 30, "This animal can bark" },
                    { new Guid("fa5429f9-f296-4170-aec1-4be61529b967"), "Poodle", true, "Rocky", "Dog", 15, "This animal can bark" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { new Guid("33175bd8-2840-4d6e-aad6-7be16c28ebd3"), "$2a$11$LdZPvw/kxCMauiYsjWi8r.WItTaSCtNjNn3CI7oBpCqvDhxpdav5m", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("0abfd852-25f9-4bbb-84a3-8842e5ee0475"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("0cd93c3f-66e5-4392-8980-cccc07dda003"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("12223ef9-03b8-44d5-9801-5570fc79b5b4"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("7f10ba7d-d81b-445d-a1e9-0b4d1ba63441"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("94572362-3c86-4777-b990-514f0ff85135"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("2f55c8c0-7cc0-4d28-b666-fce48b2ec835"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("30f2d255-cedc-491f-b7e0-d48f3e36504f"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("a0c15204-7700-4d23-816a-a0d8081ee01f"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("afb9ffa5-dd75-4114-a237-5a8c4b36cd65"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d7b5f156-4159-4cba-a632-aedfe31980cd"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("0c3ce72e-dcad-4622-be37-211105d3787c"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("40dc7260-e136-4f4c-980b-970057c3ab8e"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("5e9ecac1-d1d4-4742-8fa0-d770cd866285"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("a4c56d9e-f867-4297-aae7-5d13eb4d404f"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("f851acbe-935c-4137-a020-7aea7b7a7539"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("fa5429f9-f296-4170-aec1-4be61529b967"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33175bd8-2840-4d6e-aad6-7be16c28ebd3"));

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "Color", "LikesToPlay", "Name", "TypeOfAnimal", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("007dd11d-8618-479f-96f9-d4dedd91282d"), "Green", true, "Kiwi", "Bird", "This animal can fly" },
                    { new Guid("20421861-45c8-4c73-a9d3-86d298591e3d"), "Yellow", true, "Sunshine", "Bird", "This animal can fly" },
                    { new Guid("29183377-ff6e-4ba1-a0b9-7f90faf85961"), "Blue", true, "Sky", "Bird", "This animal can fly" },
                    { new Guid("73399501-7256-4bd3-b2c1-5fd13da28602"), "White", true, "Snowflake", "Bird", "This animal can fly" },
                    { new Guid("a982bf15-f1c9-47fc-97cb-cef2e5940c7e"), "Red", true, "Cherry", "Bird", "This animal can fly" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "TypeOfAnimal", "Weight", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("03862852-72f2-42e0-90d4-3197a507fe30"), "Maine Coon", true, "Shadow", "Cat", 15, "This animal can meow" },
                    { new Guid("7281eb31-94ae-4e94-8d77-80a07c928001"), "Siamese", true, "Whiskers", "Cat", 8, "This animal can meow" },
                    { new Guid("7d564f19-0f18-41ee-98aa-4d5c395cbea7"), "Persian", true, "Mittens", "Cat", 10, "This animal can meow" },
                    { new Guid("d0adcbc7-b9b5-4145-aec7-b70124454f1e"), "Bengal", true, "Tiger", "Cat", 11, "This animal can meow" },
                    { new Guid("d86fdb16-7885-495b-8d20-997ffe5da528"), "Ragdoll", true, "Smokey", "Cat", 12, "This animal can meow" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "TypeOfAnimal", "Weight", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("165bfa21-b3ce-4810-962a-ab98f70c369f"), "Labrador", true, "Luna", "Dog", 25, "This animal can bark" },
                    { new Guid("a0e4df16-14db-4679-8278-d045d2554525"), "German Shepherd", true, "Bella", "Dog", 30, "This animal can bark" },
                    { new Guid("b04dc8bf-7285-461c-9ba7-7eed3c8b0ba6"), "Beagle", true, "Daisy", "Dog", 18, "This animal can bark" },
                    { new Guid("ba2918a9-89d8-4941-85ee-20680fca43f0"), "Golden Retriever", true, "Riley", "Dog", 30, "This animal can bark" },
                    { new Guid("ed2fb8ad-d5c5-42af-8acd-aadd8dcad39b"), "Poodle", true, "Rocky", "Dog", 15, "This animal can bark" },
                    { new Guid("f76e4ed8-dad7-4f72-bf78-d85e89f437c7"), "Golden Retriever", true, "Max", "Dog", 28, "This animal can bark" }
                });
        }
    }
}

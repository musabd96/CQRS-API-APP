using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeadAnimalUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("33ffe6da-57f5-48f1-9bfc-7a96206556c6"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("609224ae-2051-4e46-b8d8-dc0f5bd3e750"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("7af7985f-e16c-4581-bbce-43f7b32f1e31"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("8fbdb8d3-6a2d-43aa-95df-3c8256c6096a"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("faa083a1-fcf5-4932-9307-8c9264776e05"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("513d9113-e1eb-486f-9bbd-7fd5cde54ba4"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("52138dc5-9ac8-4a03-8e46-cb28914b98b2"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("a589074e-026b-404f-9d0d-6b66619ccc32"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("b20af3ef-6e1c-4a0c-b11d-e7418995d032"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d65b22ab-fd11-40a4-ba0b-b179c4706ab5"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("27fc89cf-5a56-4177-a66c-f90ae605d3f2"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("6cc3d811-ea40-42cb-8b47-4a06cba5376f"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("6d8b6946-3f8b-472d-9d8f-62bfa7847362"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("77cf7fc4-53cd-485f-aa48-76060540d897"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("b12763b2-1f18-4024-b8a7-c4815821d1c9"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("d42e2ab3-10c9-4c92-98bb-4137dfb80bc6"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("33ffe6da-57f5-48f1-9bfc-7a96206556c6"), "Yellow", true, "Sunshine", "Bird", "This animal can fly" },
                    { new Guid("609224ae-2051-4e46-b8d8-dc0f5bd3e750"), "Red", true, "Cherry", "Bird", "This animal can fly" },
                    { new Guid("7af7985f-e16c-4581-bbce-43f7b32f1e31"), "Blue", true, "Sky", "Bird", "This animal can fly" },
                    { new Guid("8fbdb8d3-6a2d-43aa-95df-3c8256c6096a"), "White", true, "Snowflake", "Bird", "This animal can fly" },
                    { new Guid("faa083a1-fcf5-4932-9307-8c9264776e05"), "Green", true, "Kiwi", "Bird", "This animal can fly" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "TypeOfAnimal", "Weight", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("513d9113-e1eb-486f-9bbd-7fd5cde54ba4"), "Maine Coon", true, "Shadow", "Cat", 15, "This animal can meow" },
                    { new Guid("52138dc5-9ac8-4a03-8e46-cb28914b98b2"), "Bengal", true, "Tiger", "Cat", 11, "This animal can meow" },
                    { new Guid("a589074e-026b-404f-9d0d-6b66619ccc32"), "Ragdoll", true, "Smokey", "Cat", 12, "This animal can meow" },
                    { new Guid("b20af3ef-6e1c-4a0c-b11d-e7418995d032"), "Siamese", true, "Whiskers", "Cat", 8, "This animal can meow" },
                    { new Guid("d65b22ab-fd11-40a4-ba0b-b179c4706ab5"), "Persian", true, "Mittens", "Cat", 10, "This animal can meow" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "TypeOfAnimal", "Weight", "animalCanDo" },
                values: new object[,]
                {
                    { new Guid("27fc89cf-5a56-4177-a66c-f90ae605d3f2"), "Golden Retriever", true, "Max", "Dog", 28, "This animal can bark" },
                    { new Guid("6cc3d811-ea40-42cb-8b47-4a06cba5376f"), "Golden Retriever", true, "Riley", "Dog", 30, "This animal can bark" },
                    { new Guid("6d8b6946-3f8b-472d-9d8f-62bfa7847362"), "Beagle", true, "Daisy", "Dog", 18, "This animal can bark" },
                    { new Guid("77cf7fc4-53cd-485f-aa48-76060540d897"), "Labrador", true, "Luna", "Dog", 25, "This animal can bark" },
                    { new Guid("b12763b2-1f18-4024-b8a7-c4815821d1c9"), "German Shepherd", true, "Bella", "Dog", 30, "This animal can bark" },
                    { new Guid("d42e2ab3-10c9-4c92-98bb-4137dfb80bc6"), "Poodle", true, "Rocky", "Dog", 15, "This animal can bark" }
                });
        }
    }
}

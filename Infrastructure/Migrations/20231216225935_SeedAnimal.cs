using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedAnimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "Color", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("0ae3521d-edec-4164-8f63-0962de8d9189"), "Yellow", true, "Sunshine" },
                    { new Guid("7e49c247-d69c-4c47-88d2-744eaa0dcd33"), "Green", true, "Kiwi" },
                    { new Guid("b016be05-0b22-4e42-ab90-c23b66ce3b9f"), "White", true, "Snowflake" },
                    { new Guid("e3f2085c-18dc-4e96-8125-8cc35a05e735"), "Red", true, "Cherry" },
                    { new Guid("f3791a20-e3b4-4710-bc0c-a654e5308039"), "Blue", true, "Sky" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("04e636fe-bf22-442c-9f4e-0abbfc409853"), "Siamese", true, "Whiskers", 8 },
                    { new Guid("39c5ec24-1ddc-4161-8d48-17c57b4cf233"), "Maine Coon", true, "Shadow", 15 },
                    { new Guid("9b83bcc1-6e86-4704-9bf6-962ca5bc3fec"), "Bengal", true, "Tiger", 11 },
                    { new Guid("d50e2524-9447-4993-b572-e2caddb3f3f7"), "Ragdoll", true, "Smokey", 12 },
                    { new Guid("f9c917df-7452-47ec-9cc3-c5888a68ca6a"), "Persian", true, "Mittens", 10 }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("554240e5-4e9a-46b2-947e-593fe27b5d82"), "Poodle", true, "Rocky", 15 },
                    { new Guid("8f7879cd-d5fb-4d1f-9341-6a99716d5e62"), "Beagle", true, "Daisy", 18 },
                    { new Guid("a88fed4b-3d00-4d0f-bcf4-0219ac362939"), "Labrador", true, "Luna", 25 },
                    { new Guid("b4a900c1-d1a7-43e9-a23d-c129ab9e6623"), "Golden Retriever", true, "Riley", 30 },
                    { new Guid("b517fae1-cbf3-441a-a8b2-b87c8581e7e4"), "German Shepherd", true, "Bella", 30 },
                    { new Guid("dd90b38e-b669-4c5e-8124-5db0934616f1"), "Golden Retriever", true, "Max", 28 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("0ae3521d-edec-4164-8f63-0962de8d9189"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("7e49c247-d69c-4c47-88d2-744eaa0dcd33"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("b016be05-0b22-4e42-ab90-c23b66ce3b9f"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("e3f2085c-18dc-4e96-8125-8cc35a05e735"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("f3791a20-e3b4-4710-bc0c-a654e5308039"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("04e636fe-bf22-442c-9f4e-0abbfc409853"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("39c5ec24-1ddc-4161-8d48-17c57b4cf233"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("9b83bcc1-6e86-4704-9bf6-962ca5bc3fec"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d50e2524-9447-4993-b572-e2caddb3f3f7"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("f9c917df-7452-47ec-9cc3-c5888a68ca6a"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("554240e5-4e9a-46b2-947e-593fe27b5d82"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("8f7879cd-d5fb-4d1f-9341-6a99716d5e62"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("a88fed4b-3d00-4d0f-bcf4-0219ac362939"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("b4a900c1-d1a7-43e9-a23d-c129ab9e6623"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("b517fae1-cbf3-441a-a8b2-b87c8581e7e4"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("dd90b38e-b669-4c5e-8124-5db0934616f1"));
        }
    }
}

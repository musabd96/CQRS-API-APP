using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeadAnimalUpdate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("24cc2a8d-4c11-4216-b6eb-8508a35d5262"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("3bf8699a-cff9-4231-9cc6-a2669418a10c"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("755efddb-afec-48d8-8977-0494741aaa9e"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("c7b66443-e962-4ffc-93e6-91995023b16f"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("db156db9-9253-412a-bb8f-a2e44c3e2d7f"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("13537654-700b-47ca-98d0-e31e22bf6bb6"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("7279e1c1-9dc9-4787-93d7-e2572f7811eb"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("9d53e078-f54b-48a9-ad15-4dd456f56079"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("c197b233-3249-48eb-b016-74ba090ba989"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("c2acbc1b-7fdc-4e2e-92be-8a2a2336168e"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("4779a5c5-9ede-4d35-ae98-bf552a650d3b"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("4a843d7a-1eca-449c-8d7c-ba5f168ebf35"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("a79ab4c5-a5e8-4404-87f9-bf3c15cce925"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("c48537b3-3aab-4503-bf67-1c197c076ac3"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("cc756eca-7302-4ffa-9c5a-d354b9f76ca1"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("e59de086-1975-4c19-9efe-f38c075bb74b"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

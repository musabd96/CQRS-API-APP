using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add25BirdsWithColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("25886918-db5f-457d-a8e3-a2a7fb2f4c8f"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("5407e69e-d034-499d-8e68-749ea9a3a4f1"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("ffec24fb-1c7d-459c-9d25-aa531ba0df65"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("06c6e589-1c96-401b-923c-ec16c6a27e22"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("0b852102-3d55-4643-add2-da45050af24a"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("0c5d326e-f238-4164-b843-dcb02e09fea8"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("10c28361-6d35-443c-a5dc-3d043aa942ba"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("12dc9df9-06a2-406b-ad88-b656e497e015"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("1f3c961d-02d1-4dac-9144-71c6ee13736f"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("3a396962-c592-46d6-bbfc-3eb249bdde24"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("3c2341f0-ff47-4f33-941c-1cacbf8221fa"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("3d3eea4f-0cee-4dd4-a000-4d6b5fb8753b"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("45a2a104-7fd2-4720-8cef-5258596dd05c"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("68fd4acc-eb0c-419d-b601-e539e8b9d203"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("7700599f-666d-4b89-806f-337f2fe5a589"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("78dd7231-bb34-499c-bd5d-f64d88c643c0"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("7dbe2b59-003b-41ea-919b-45f46960dd4c"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("900a4e1c-f308-4539-ae7d-449c4b8e80db"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("958aebad-f44f-4479-b2b4-49778eb11ecc"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("aea96135-6847-4611-a30e-803d634dadee"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("c094aafe-ba42-4683-8ecb-740505baf1be"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("ca138218-f7d8-4968-aee6-32d67b3496a0"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("cb2a4c35-8eb7-46d5-a0ed-f465c6ad83ab"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d1b86d03-85de-4422-b761-abde949cd331"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d1c16cfb-efcf-422a-b07a-a5c2f2a77cd6"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("e149238e-7a84-419f-9806-39a6ecb2e7fb"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("e8c55c58-b425-446d-97aa-3d6481f33f6e"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("ebbf41ab-e6ec-4db0-8215-35e858ec6104"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("01fdb11b-3e33-457d-bd6c-7a265aa180a1"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("131ae03b-cbc5-44ac-a7ef-b13f0dc64c65"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("142cce1c-b43e-4d41-b758-503ab5a734fb"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("31edc8b9-a070-440f-b865-882eb1eeb761"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("322e1cd1-5999-4024-8793-fcf36d28110a"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("34f7eb8d-240a-4c41-871a-5cb04bdf4971"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("3b57448c-e2a1-4832-b7ca-d508afe7fecf"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("4b1af5a1-9105-4d06-9582-e33d4f896071"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("55955b6a-0fe2-40cb-b98e-d693974a61e5"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("5eac3c12-38dd-42d6-a7fd-ca754f4ce088"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("63bb81af-6829-4dd8-bf2b-87f3bcd67a6b"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("6aaa05ec-0546-4bc5-a368-6249f890822b"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("711da70c-0e55-4a16-91b6-be7d42abf6c4"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("78675769-1db3-420b-a8f1-b0b75c9d397c"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("7c774337-8c9c-4c05-a38e-c58743ef4eb2"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("8e430d5b-3730-48b4-aad3-125c1eb22608"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("a20163b5-c42a-479d-ab85-6d4038cffc48"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("a21276a9-15c1-4b3f-84ed-098eb1bde20e"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("acb8c559-d746-4506-b65d-150bfce00c08"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("d45fb3de-21f0-445f-a274-a6afd77f71f9"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("de4399f7-31fc-45b3-8231-622bb73d7571"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("e5d399ac-a2ca-4b5e-bfe0-534e9c27ab6b"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("e6ec245c-e0d0-44bf-925e-10e72b6fbd6f"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("e9692de1-4666-432c-8854-7eb56e8dec43"));

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Birds",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "Color", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("052fabc3-d4ff-4e02-924f-9fe9a27b389a"), "Green", true, "Kiwi" },
                    { new Guid("058607ec-a97a-42d3-8ef7-393865bf578e"), "Blue", true, "Rose" },
                    { new Guid("07c0c9a2-274a-4f4e-a69a-b2f39498b0e1"), "Blue", true, "Amber" },
                    { new Guid("110dfff2-9152-42bb-8cde-6e9ef6294791"), "White", true, "Crimson" },
                    { new Guid("1a521569-d334-4a75-8e76-7ecc3c6d9e93"), "Red", true, "Teal" },
                    { new Guid("337390d2-ca5e-4c98-93f3-1f9866095a51"), "White", true, "Indigo" },
                    { new Guid("42549e6a-7bf1-427e-8c1d-93a20b0477d9"), "Blue", true, "Emerald" },
                    { new Guid("53ea3027-fa73-41b7-bf13-fe9055fa5e32"), "Green", true, "Pearl" },
                    { new Guid("689ed36e-8675-45eb-b314-e10e513dcce8"), "Red", true, "Sunset" },
                    { new Guid("69900a36-e932-480b-8457-4d1223dd2b15"), "Blue", true, "Sky" },
                    { new Guid("69a3d6a5-e870-4702-b671-acb5e0009971"), "Blue", true, "Sunny" },
                    { new Guid("6c0ee6d5-e001-451c-b0fb-1054377e45b2"), "White", true, "Snowflake" },
                    { new Guid("6d124487-6b04-4159-8d7b-5f3120c5b530"), "Red", true, "Mango" },
                    { new Guid("76ed5a41-6165-40df-8c42-68794423c6b8"), "Green", true, "Goldie" },
                    { new Guid("7aea54d3-1bac-4c11-a722-ed486b104302"), "White", true, "Silver" },
                    { new Guid("7d7d25ac-7cef-49dc-abb4-2f01e929f82c"), "Yellow", true, "Onyx" },
                    { new Guid("85f4f38c-5a9d-43ba-8ccb-bc4e7dbf0dcc"), "Green", true, "Midnight" },
                    { new Guid("90d9f312-a959-408c-981e-dd77379a0b68"), "White", true, "Violet" },
                    { new Guid("9ed1134e-a607-4512-9c21-5db8ec3e6b7d"), "Yellow", true, "Azure" },
                    { new Guid("9f8b77ff-4464-4df5-b901-e5667e5bbb91"), "Red", true, "Cherry" },
                    { new Guid("ad836904-4ff0-4d08-94bd-05972550da01"), "Red", true, "Lavender" },
                    { new Guid("b358794b-db06-485d-900e-91306d1dc254"), "Yellow", true, "Sunshine" },
                    { new Guid("caad7b2f-2c61-475a-a789-0b6e42c03c2d"), "Green", true, "Ruby" },
                    { new Guid("cb5f445b-a89c-4f7d-8241-add1dbf23271"), "Yellow", true, "Coral" },
                    { new Guid("e2a84665-48f7-4eeb-aaa6-dc1fb3db4138"), "Yellow", true, "Silverwing" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("1403e3f8-3cd5-4f27-a1d2-21ab40d6cffe"), "Siamese", true, "Luna", 7 },
                    { new Guid("1beb56cc-5fc8-43e0-917a-68554a0cc742"), "Maine Coon", true, "Shadow", 15 },
                    { new Guid("2462592e-4603-4512-8f0e-077f130c73a9"), "Ragdoll", true, "Smokey", 12 },
                    { new Guid("49a42139-a324-4b69-9806-bb9bf4e994b4"), "Persian", true, "Casper", 11 },
                    { new Guid("55483366-7437-4331-b474-977d0e766cfe"), "Bengal", true, "Sasha", 9 },
                    { new Guid("6168baed-9d51-435f-b5e2-ebf121c3caf9"), "Persian", true, "Mittens", 10 },
                    { new Guid("73cb4746-57d7-4be5-9a94-f8061cd7f259"), "Siamese", true, "Lola", 7 },
                    { new Guid("7e2e2785-d1d2-4ac9-87df-9f0a0ba6e01b"), "Maine Coon", true, "Leo", 14 },
                    { new Guid("8d847ed1-19a8-41e5-bce2-fd877d2e4c79"), "Bengal", true, "Milo", 9 },
                    { new Guid("9413a621-287a-4680-83fe-d37f2b6442d5"), "Maine Coon", true, "Oliver", 16 },
                    { new Guid("9d7119eb-bd2a-4dd6-b2e4-a264d7af2f73"), "Bengal", true, "Charlie", 10 },
                    { new Guid("9ee75dbb-4b30-494b-8e86-2ff0889322d7"), "Persian", true, "Salem", 10 },
                    { new Guid("a6207ffe-4d15-4808-9f28-ca719e6c0436"), "Persian", true, "Oreo", 9 },
                    { new Guid("a82d7846-1c11-455b-a560-3f82ad33b7c3"), "Siamese", true, "Whiskers", 8 },
                    { new Guid("a8f67567-5ec9-4c9c-951c-f7ca498a504e"), "Siamese", true, "Misty", 8 },
                    { new Guid("ab89191a-1350-4207-8633-f48f4dc71a27"), "Maine Coon", true, "Mittens", 14 },
                    { new Guid("abcdb9c9-d9b1-4ff7-994e-dde1a0954a2b"), "Ragdoll", true, "Ziggy", 12 },
                    { new Guid("b53a8da9-95c7-4511-a17a-dc8d322125df"), "Bengal", true, "Tiger", 11 },
                    { new Guid("b5a95274-1ec5-4920-8806-39aceaa0adfd"), "Persian", true, "Gizmo", 9 },
                    { new Guid("bc69facd-6db0-4ef9-b601-a07bf0b0be7d"), "Bengal", true, "Simba", 10 },
                    { new Guid("d7802f65-59ae-4f1d-98bd-240f23816eaa"), "Ragdoll", true, "Cleo", 11 },
                    { new Guid("dd8d8eb3-23f1-4180-b34e-4f4389a0c086"), "Ragdoll", true, "Mocha", 11 },
                    { new Guid("f01e5d48-bded-4c58-9c78-861ebec2a052"), "Maine Coon", true, "Nala", 13 },
                    { new Guid("f032025b-1f83-4caa-8f08-36e4af2f6afe"), "Siamese", true, "Whisper", 8 },
                    { new Guid("f6ee128d-17be-4ded-9709-9b915bbb8d9f"), "Ragdoll", true, "Whiskey", 12 }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("0a3966c3-6b36-408b-8249-d99881736f0e"), "Poodle", true, "Oliver", 16 },
                    { new Guid("147b359c-6870-42a5-b694-a7f35ad642fe"), "German Shepherd", true, "Bella", 30 },
                    { new Guid("180c1101-5534-4174-ac5f-44282f0ea326"), "Golden Retriever", true, "Max", 28 },
                    { new Guid("1e90f89e-61af-4c83-9728-21d7421ee6ba"), "Golden Retriever", true, "Coco", 27 },
                    { new Guid("2b1bf291-e3b4-4f51-a533-1cad6ca9ff86"), "Golden Retriever", true, "Riley", 30 },
                    { new Guid("49166967-fce0-4b00-b36a-ede6a1fefd41"), "Beagle", true, "Ruby", 19 },
                    { new Guid("4f8bdf84-2db8-4639-89b2-036a8b6a6a7d"), "Poodle", true, "Sophie", 17 },
                    { new Guid("937efb74-e703-4496-a306-0d853fc8b782"), "Beagle", true, "Leo", 21 },
                    { new Guid("a08eb957-0d05-4887-bdc4-b751dfe5b403"), "Beagle", true, "Zeus", 20 },
                    { new Guid("b10dde17-9fab-4361-ae0c-e9a09b1b389f"), "Labrador", true, "Sadie", 25 },
                    { new Guid("b2ee19a1-9d7d-4b7a-9075-e54b9a822eed"), "German Shepherd", true, "Chloe", 31 },
                    { new Guid("b4567fc7-5f94-49fc-b681-712490727e81"), "Labrador", true, "Cooper", 24 },
                    { new Guid("b89aa60f-a49b-40b7-b57e-1363bff87e53"), "Labrador", true, "Lucy", 26 },
                    { new Guid("bec0e6a9-60e9-40c8-a2f5-6bc683ae3cc6"), "Poodle", true, "Rosie", 14 },
                    { new Guid("c4ccf03a-eef7-42fc-9d35-d0735d3dfcdd"), "German Shepherd", true, "Tucker", 32 },
                    { new Guid("c5e66a5b-942d-4ed8-a863-79810b677430"), "Poodle", true, "Rocky", 15 },
                    { new Guid("c5fe411a-cbd0-4651-aea7-82a443516bc3"), "Beagle", true, "Daisy", 18 },
                    { new Guid("c8924552-9981-4d12-9e17-73b83dd9364b"), "Golden Retriever", true, "Duke", 29 },
                    { new Guid("c94311e2-8402-45a6-93fc-610e6190bf1b"), "German Shepherd", true, "Milo", 28 },
                    { new Guid("cc017fa4-4572-4409-93bd-eb9f85d40401"), "Labrador", true, "Charlie", 22 },
                    { new Guid("dcd57fc7-3f8e-45c0-8b0e-2be3d2f18370"), "Golden Retriever", true, "Mia", 29 },
                    { new Guid("ea235887-ceae-4165-b2d3-870683c549eb"), "Labrador", true, "Luna", 25 },
                    { new Guid("fd270548-ff9b-4a83-9526-666ea01a1c0c"), "Labrador", true, "Thor", 23 },
                    { new Guid("ff8e04ff-ec57-4ffe-a6ca-37471918bc80"), "Golden Retriever", true, "Pepper", 26 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("052fabc3-d4ff-4e02-924f-9fe9a27b389a"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("058607ec-a97a-42d3-8ef7-393865bf578e"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("07c0c9a2-274a-4f4e-a69a-b2f39498b0e1"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("110dfff2-9152-42bb-8cde-6e9ef6294791"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("1a521569-d334-4a75-8e76-7ecc3c6d9e93"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("337390d2-ca5e-4c98-93f3-1f9866095a51"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("42549e6a-7bf1-427e-8c1d-93a20b0477d9"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("53ea3027-fa73-41b7-bf13-fe9055fa5e32"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("689ed36e-8675-45eb-b314-e10e513dcce8"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("69900a36-e932-480b-8457-4d1223dd2b15"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("69a3d6a5-e870-4702-b671-acb5e0009971"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("6c0ee6d5-e001-451c-b0fb-1054377e45b2"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("6d124487-6b04-4159-8d7b-5f3120c5b530"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("76ed5a41-6165-40df-8c42-68794423c6b8"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("7aea54d3-1bac-4c11-a722-ed486b104302"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("7d7d25ac-7cef-49dc-abb4-2f01e929f82c"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("85f4f38c-5a9d-43ba-8ccb-bc4e7dbf0dcc"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("90d9f312-a959-408c-981e-dd77379a0b68"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("9ed1134e-a607-4512-9c21-5db8ec3e6b7d"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("9f8b77ff-4464-4df5-b901-e5667e5bbb91"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("ad836904-4ff0-4d08-94bd-05972550da01"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("b358794b-db06-485d-900e-91306d1dc254"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("caad7b2f-2c61-475a-a789-0b6e42c03c2d"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("cb5f445b-a89c-4f7d-8241-add1dbf23271"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("e2a84665-48f7-4eeb-aaa6-dc1fb3db4138"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("1403e3f8-3cd5-4f27-a1d2-21ab40d6cffe"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("1beb56cc-5fc8-43e0-917a-68554a0cc742"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("2462592e-4603-4512-8f0e-077f130c73a9"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("49a42139-a324-4b69-9806-bb9bf4e994b4"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("55483366-7437-4331-b474-977d0e766cfe"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("6168baed-9d51-435f-b5e2-ebf121c3caf9"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("73cb4746-57d7-4be5-9a94-f8061cd7f259"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("7e2e2785-d1d2-4ac9-87df-9f0a0ba6e01b"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("8d847ed1-19a8-41e5-bce2-fd877d2e4c79"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("9413a621-287a-4680-83fe-d37f2b6442d5"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("9d7119eb-bd2a-4dd6-b2e4-a264d7af2f73"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("9ee75dbb-4b30-494b-8e86-2ff0889322d7"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("a6207ffe-4d15-4808-9f28-ca719e6c0436"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("a82d7846-1c11-455b-a560-3f82ad33b7c3"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("a8f67567-5ec9-4c9c-951c-f7ca498a504e"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("ab89191a-1350-4207-8633-f48f4dc71a27"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("abcdb9c9-d9b1-4ff7-994e-dde1a0954a2b"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("b53a8da9-95c7-4511-a17a-dc8d322125df"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("b5a95274-1ec5-4920-8806-39aceaa0adfd"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("bc69facd-6db0-4ef9-b601-a07bf0b0be7d"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("d7802f65-59ae-4f1d-98bd-240f23816eaa"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("dd8d8eb3-23f1-4180-b34e-4f4389a0c086"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("f01e5d48-bded-4c58-9c78-861ebec2a052"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("f032025b-1f83-4caa-8f08-36e4af2f6afe"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("f6ee128d-17be-4ded-9709-9b915bbb8d9f"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("0a3966c3-6b36-408b-8249-d99881736f0e"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("147b359c-6870-42a5-b694-a7f35ad642fe"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("180c1101-5534-4174-ac5f-44282f0ea326"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("1e90f89e-61af-4c83-9728-21d7421ee6ba"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("2b1bf291-e3b4-4f51-a533-1cad6ca9ff86"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("49166967-fce0-4b00-b36a-ede6a1fefd41"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("4f8bdf84-2db8-4639-89b2-036a8b6a6a7d"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("937efb74-e703-4496-a306-0d853fc8b782"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("a08eb957-0d05-4887-bdc4-b751dfe5b403"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("b10dde17-9fab-4361-ae0c-e9a09b1b389f"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("b2ee19a1-9d7d-4b7a-9075-e54b9a822eed"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("b4567fc7-5f94-49fc-b681-712490727e81"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("b89aa60f-a49b-40b7-b57e-1363bff87e53"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("bec0e6a9-60e9-40c8-a2f5-6bc683ae3cc6"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("c4ccf03a-eef7-42fc-9d35-d0735d3dfcdd"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("c5e66a5b-942d-4ed8-a863-79810b677430"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("c5fe411a-cbd0-4651-aea7-82a443516bc3"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("c8924552-9981-4d12-9e17-73b83dd9364b"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("c94311e2-8402-45a6-93fc-610e6190bf1b"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("cc017fa4-4572-4409-93bd-eb9f85d40401"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("dcd57fc7-3f8e-45c0-8b0e-2be3d2f18370"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("ea235887-ceae-4165-b2d3-870683c549eb"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("fd270548-ff9b-4a83-9526-666ea01a1c0c"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("ff8e04ff-ec57-4ffe-a6ca-37471918bc80"));

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Birds");

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("25886918-db5f-457d-a8e3-a2a7fb2f4c8f"), true, "Max" },
                    { new Guid("5407e69e-d034-499d-8e68-749ea9a3a4f1"), true, "Alex" },
                    { new Guid("ffec24fb-1c7d-459c-9d25-aa531ba0df65"), true, "Sofia" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("06c6e589-1c96-401b-923c-ec16c6a27e22"), "Bengal", true, "Milo", 9 },
                    { new Guid("0b852102-3d55-4643-add2-da45050af24a"), "Bengal", true, "Simba", 10 },
                    { new Guid("0c5d326e-f238-4164-b843-dcb02e09fea8"), "Persian", true, "Mittens", 10 },
                    { new Guid("10c28361-6d35-443c-a5dc-3d043aa942ba"), "Maine Coon", true, "Leo", 14 },
                    { new Guid("12dc9df9-06a2-406b-ad88-b656e497e015"), "Siamese", true, "Whiskers", 8 },
                    { new Guid("1f3c961d-02d1-4dac-9144-71c6ee13736f"), "Siamese", true, "Misty", 8 },
                    { new Guid("3a396962-c592-46d6-bbfc-3eb249bdde24"), "Maine Coon", true, "Oliver", 16 },
                    { new Guid("3c2341f0-ff47-4f33-941c-1cacbf8221fa"), "Ragdoll", true, "Whiskey", 12 },
                    { new Guid("3d3eea4f-0cee-4dd4-a000-4d6b5fb8753b"), "Siamese", true, "Luna", 7 },
                    { new Guid("45a2a104-7fd2-4720-8cef-5258596dd05c"), "Ragdoll", true, "Ziggy", 12 },
                    { new Guid("68fd4acc-eb0c-419d-b601-e539e8b9d203"), "Persian", true, "Salem", 10 },
                    { new Guid("7700599f-666d-4b89-806f-337f2fe5a589"), "Persian", true, "Gizmo", 9 },
                    { new Guid("78dd7231-bb34-499c-bd5d-f64d88c643c0"), "Bengal", true, "Tiger", 11 },
                    { new Guid("7dbe2b59-003b-41ea-919b-45f46960dd4c"), "Siamese", true, "Whisper", 8 },
                    { new Guid("900a4e1c-f308-4539-ae7d-449c4b8e80db"), "Persian", true, "Oreo", 9 },
                    { new Guid("958aebad-f44f-4479-b2b4-49778eb11ecc"), "Persian", true, "Casper", 11 },
                    { new Guid("aea96135-6847-4611-a30e-803d634dadee"), "Ragdoll", true, "Smokey", 12 },
                    { new Guid("c094aafe-ba42-4683-8ecb-740505baf1be"), "Bengal", true, "Charlie", 10 },
                    { new Guid("ca138218-f7d8-4968-aee6-32d67b3496a0"), "Ragdoll", true, "Cleo", 11 },
                    { new Guid("cb2a4c35-8eb7-46d5-a0ed-f465c6ad83ab"), "Ragdoll", true, "Mocha", 11 },
                    { new Guid("d1b86d03-85de-4422-b761-abde949cd331"), "Siamese", true, "Lola", 7 },
                    { new Guid("d1c16cfb-efcf-422a-b07a-a5c2f2a77cd6"), "Bengal", true, "Sasha", 9 },
                    { new Guid("e149238e-7a84-419f-9806-39a6ecb2e7fb"), "Maine Coon", true, "Shadow", 15 },
                    { new Guid("e8c55c58-b425-446d-97aa-3d6481f33f6e"), "Maine Coon", true, "Mittens", 14 },
                    { new Guid("ebbf41ab-e6ec-4db0-8215-35e858ec6104"), "Maine Coon", true, "Nala", 13 }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("01fdb11b-3e33-457d-bd6c-7a265aa180a1"), "Golden Retriever", true, "Pepper", 26 },
                    { new Guid("131ae03b-cbc5-44ac-a7ef-b13f0dc64c65"), "Poodle", true, "Rocky", 15 },
                    { new Guid("142cce1c-b43e-4d41-b758-503ab5a734fb"), "Beagle", true, "Leo", 21 },
                    { new Guid("31edc8b9-a070-440f-b865-882eb1eeb761"), "German Shepherd", true, "Chloe", 31 },
                    { new Guid("322e1cd1-5999-4024-8793-fcf36d28110a"), "Golden Retriever", true, "Max", 28 },
                    { new Guid("34f7eb8d-240a-4c41-871a-5cb04bdf4971"), "Labrador", true, "Sadie", 25 },
                    { new Guid("3b57448c-e2a1-4832-b7ca-d508afe7fecf"), "Labrador", true, "Thor", 23 },
                    { new Guid("4b1af5a1-9105-4d06-9582-e33d4f896071"), "Poodle", true, "Rosie", 14 },
                    { new Guid("55955b6a-0fe2-40cb-b98e-d693974a61e5"), "Beagle", true, "Daisy", 18 },
                    { new Guid("5eac3c12-38dd-42d6-a7fd-ca754f4ce088"), "Golden Retriever", true, "Duke", 29 },
                    { new Guid("63bb81af-6829-4dd8-bf2b-87f3bcd67a6b"), "Labrador", true, "Charlie", 22 },
                    { new Guid("6aaa05ec-0546-4bc5-a368-6249f890822b"), "Golden Retriever", true, "Riley", 30 },
                    { new Guid("711da70c-0e55-4a16-91b6-be7d42abf6c4"), "Poodle", true, "Oliver", 16 },
                    { new Guid("78675769-1db3-420b-a8f1-b0b75c9d397c"), "German Shepherd", true, "Bella", 30 },
                    { new Guid("7c774337-8c9c-4c05-a38e-c58743ef4eb2"), "Labrador", true, "Cooper", 24 },
                    { new Guid("8e430d5b-3730-48b4-aad3-125c1eb22608"), "German Shepherd", true, "Tucker", 32 },
                    { new Guid("a20163b5-c42a-479d-ab85-6d4038cffc48"), "Beagle", true, "Ruby", 19 },
                    { new Guid("a21276a9-15c1-4b3f-84ed-098eb1bde20e"), "Labrador", true, "Lucy", 26 },
                    { new Guid("acb8c559-d746-4506-b65d-150bfce00c08"), "Beagle", true, "Zeus", 20 },
                    { new Guid("d45fb3de-21f0-445f-a274-a6afd77f71f9"), "Golden Retriever", true, "Coco", 27 },
                    { new Guid("de4399f7-31fc-45b3-8231-622bb73d7571"), "German Shepherd", true, "Milo", 28 },
                    { new Guid("e5d399ac-a2ca-4b5e-bfe0-534e9c27ab6b"), "Labrador", true, "Luna", 25 },
                    { new Guid("e6ec245c-e0d0-44bf-925e-10e72b6fbd6f"), "Poodle", true, "Sophie", 17 },
                    { new Guid("e9692de1-4666-432c-8854-7eb56e8dec43"), "Golden Retriever", true, "Mia", 29 }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add20CatDogWithBreedWeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("07e1b8c5-7927-45ee-95ed-e2e6d6b7fc9a"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("88404411-8a2b-489c-a193-984a8e197704"));

            migrationBuilder.DeleteData(
                table: "Birds",
                keyColumn: "Id",
                keyValue: new Guid("eece0ea1-3bb9-4bc4-b798-e4d095d66533"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("08b877ed-a76f-40c2-ad4c-03808bd98013"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("86943bf3-c0a8-4a28-959e-0da850b1b04f"));

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: new Guid("f0daa88c-f5a8-4d6d-9b2e-57491d05399a"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("3f84e34b-865e-4d2f-86ed-357dab070670"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("b3182bfa-dbfe-4731-b373-85a3f442ef75"));

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: new Guid("bab03e79-231f-4726-a56c-45d6740aad0c"));

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Dogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Cats",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Cats");

            migrationBuilder.InsertData(
                table: "Birds",
                columns: new[] { "Id", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("07e1b8c5-7927-45ee-95ed-e2e6d6b7fc9a"), true, "Sofia" },
                    { new Guid("88404411-8a2b-489c-a193-984a8e197704"), true, "Max" },
                    { new Guid("eece0ea1-3bb9-4bc4-b798-e4d095d66533"), true, "Alex" }
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("08b877ed-a76f-40c2-ad4c-03808bd98013"), "Siamese", true, "Steven" },
                    { new Guid("86943bf3-c0a8-4a28-959e-0da850b1b04f"), "Persian", true, "Alpin" },
                    { new Guid("f0daa88c-f5a8-4d6d-9b2e-57491d05399a"), "Maine Coon", true, "Nelson" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Breed", "LikesToPlay", "Name" },
                values: new object[,]
                {
                    { new Guid("3f84e34b-865e-4d2f-86ed-357dab070670"), "German Shepherd", true, "Alfred" },
                    { new Guid("b3182bfa-dbfe-4731-b373-85a3f442ef75"), "Labrador", true, "Björn" },
                    { new Guid("bab03e79-231f-4726-a56c-45d6740aad0c"), "Golden Retriever", true, "Patrik" }
                });
        }
    }
}

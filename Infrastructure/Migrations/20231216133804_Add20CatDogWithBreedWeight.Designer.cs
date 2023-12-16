﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231216133804_Add20CatDogWithBreedWeight")]
    partial class Add20CatDogWithBreedWeight
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Models.Bird", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("LikesToPlay")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Birds");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5407e69e-d034-499d-8e68-749ea9a3a4f1"),
                            LikesToPlay = true,
                            Name = "Alex"
                        },
                        new
                        {
                            Id = new Guid("ffec24fb-1c7d-459c-9d25-aa531ba0df65"),
                            LikesToPlay = true,
                            Name = "Sofia"
                        },
                        new
                        {
                            Id = new Guid("25886918-db5f-457d-a8e3-a2a7fb2f4c8f"),
                            LikesToPlay = true,
                            Name = "Max"
                        });
                });

            modelBuilder.Entity("Domain.Models.Cat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LikesToPlay")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            Id = new Guid("12dc9df9-06a2-406b-ad88-b656e497e015"),
                            Breed = "Siamese",
                            LikesToPlay = true,
                            Name = "Whiskers",
                            Weight = 8
                        },
                        new
                        {
                            Id = new Guid("0c5d326e-f238-4164-b843-dcb02e09fea8"),
                            Breed = "Persian",
                            LikesToPlay = true,
                            Name = "Mittens",
                            Weight = 10
                        },
                        new
                        {
                            Id = new Guid("e149238e-7a84-419f-9806-39a6ecb2e7fb"),
                            Breed = "Maine Coon",
                            LikesToPlay = true,
                            Name = "Shadow",
                            Weight = 15
                        },
                        new
                        {
                            Id = new Guid("aea96135-6847-4611-a30e-803d634dadee"),
                            Breed = "Ragdoll",
                            LikesToPlay = true,
                            Name = "Smokey",
                            Weight = 12
                        },
                        new
                        {
                            Id = new Guid("78dd7231-bb34-499c-bd5d-f64d88c643c0"),
                            Breed = "Bengal",
                            LikesToPlay = true,
                            Name = "Tiger",
                            Weight = 11
                        },
                        new
                        {
                            Id = new Guid("3d3eea4f-0cee-4dd4-a000-4d6b5fb8753b"),
                            Breed = "Siamese",
                            LikesToPlay = true,
                            Name = "Luna",
                            Weight = 7
                        },
                        new
                        {
                            Id = new Guid("900a4e1c-f308-4539-ae7d-449c4b8e80db"),
                            Breed = "Persian",
                            LikesToPlay = true,
                            Name = "Oreo",
                            Weight = 9
                        },
                        new
                        {
                            Id = new Guid("10c28361-6d35-443c-a5dc-3d043aa942ba"),
                            Breed = "Maine Coon",
                            LikesToPlay = true,
                            Name = "Leo",
                            Weight = 14
                        },
                        new
                        {
                            Id = new Guid("ca138218-f7d8-4968-aee6-32d67b3496a0"),
                            Breed = "Ragdoll",
                            LikesToPlay = true,
                            Name = "Cleo",
                            Weight = 11
                        },
                        new
                        {
                            Id = new Guid("0b852102-3d55-4643-add2-da45050af24a"),
                            Breed = "Bengal",
                            LikesToPlay = true,
                            Name = "Simba",
                            Weight = 10
                        },
                        new
                        {
                            Id = new Guid("1f3c961d-02d1-4dac-9144-71c6ee13736f"),
                            Breed = "Siamese",
                            LikesToPlay = true,
                            Name = "Misty",
                            Weight = 8
                        },
                        new
                        {
                            Id = new Guid("68fd4acc-eb0c-419d-b601-e539e8b9d203"),
                            Breed = "Persian",
                            LikesToPlay = true,
                            Name = "Salem",
                            Weight = 10
                        },
                        new
                        {
                            Id = new Guid("3a396962-c592-46d6-bbfc-3eb249bdde24"),
                            Breed = "Maine Coon",
                            LikesToPlay = true,
                            Name = "Oliver",
                            Weight = 16
                        },
                        new
                        {
                            Id = new Guid("3c2341f0-ff47-4f33-941c-1cacbf8221fa"),
                            Breed = "Ragdoll",
                            LikesToPlay = true,
                            Name = "Whiskey",
                            Weight = 12
                        },
                        new
                        {
                            Id = new Guid("06c6e589-1c96-401b-923c-ec16c6a27e22"),
                            Breed = "Bengal",
                            LikesToPlay = true,
                            Name = "Milo",
                            Weight = 9
                        },
                        new
                        {
                            Id = new Guid("d1b86d03-85de-4422-b761-abde949cd331"),
                            Breed = "Siamese",
                            LikesToPlay = true,
                            Name = "Lola",
                            Weight = 7
                        },
                        new
                        {
                            Id = new Guid("958aebad-f44f-4479-b2b4-49778eb11ecc"),
                            Breed = "Persian",
                            LikesToPlay = true,
                            Name = "Casper",
                            Weight = 11
                        },
                        new
                        {
                            Id = new Guid("ebbf41ab-e6ec-4db0-8215-35e858ec6104"),
                            Breed = "Maine Coon",
                            LikesToPlay = true,
                            Name = "Nala",
                            Weight = 13
                        },
                        new
                        {
                            Id = new Guid("cb2a4c35-8eb7-46d5-a0ed-f465c6ad83ab"),
                            Breed = "Ragdoll",
                            LikesToPlay = true,
                            Name = "Mocha",
                            Weight = 11
                        },
                        new
                        {
                            Id = new Guid("c094aafe-ba42-4683-8ecb-740505baf1be"),
                            Breed = "Bengal",
                            LikesToPlay = true,
                            Name = "Charlie",
                            Weight = 10
                        },
                        new
                        {
                            Id = new Guid("7dbe2b59-003b-41ea-919b-45f46960dd4c"),
                            Breed = "Siamese",
                            LikesToPlay = true,
                            Name = "Whisper",
                            Weight = 8
                        },
                        new
                        {
                            Id = new Guid("7700599f-666d-4b89-806f-337f2fe5a589"),
                            Breed = "Persian",
                            LikesToPlay = true,
                            Name = "Gizmo",
                            Weight = 9
                        },
                        new
                        {
                            Id = new Guid("e8c55c58-b425-446d-97aa-3d6481f33f6e"),
                            Breed = "Maine Coon",
                            LikesToPlay = true,
                            Name = "Mittens",
                            Weight = 14
                        },
                        new
                        {
                            Id = new Guid("45a2a104-7fd2-4720-8cef-5258596dd05c"),
                            Breed = "Ragdoll",
                            LikesToPlay = true,
                            Name = "Ziggy",
                            Weight = 12
                        },
                        new
                        {
                            Id = new Guid("d1c16cfb-efcf-422a-b07a-a5c2f2a77cd6"),
                            Breed = "Bengal",
                            LikesToPlay = true,
                            Name = "Sasha",
                            Weight = 9
                        });
                });

            modelBuilder.Entity("Domain.Models.Dog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LikesToPlay")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e5d399ac-a2ca-4b5e-bfe0-534e9c27ab6b"),
                            Breed = "Labrador",
                            LikesToPlay = true,
                            Name = "Luna",
                            Weight = 25
                        },
                        new
                        {
                            Id = new Guid("322e1cd1-5999-4024-8793-fcf36d28110a"),
                            Breed = "Golden Retriever",
                            LikesToPlay = true,
                            Name = "Max",
                            Weight = 28
                        },
                        new
                        {
                            Id = new Guid("78675769-1db3-420b-a8f1-b0b75c9d397c"),
                            Breed = "German Shepherd",
                            LikesToPlay = true,
                            Name = "Bella",
                            Weight = 30
                        },
                        new
                        {
                            Id = new Guid("131ae03b-cbc5-44ac-a7ef-b13f0dc64c65"),
                            Breed = "Poodle",
                            LikesToPlay = true,
                            Name = "Rocky",
                            Weight = 15
                        },
                        new
                        {
                            Id = new Guid("55955b6a-0fe2-40cb-b98e-d693974a61e5"),
                            Breed = "Beagle",
                            LikesToPlay = true,
                            Name = "Daisy",
                            Weight = 18
                        },
                        new
                        {
                            Id = new Guid("63bb81af-6829-4dd8-bf2b-87f3bcd67a6b"),
                            Breed = "Labrador",
                            LikesToPlay = true,
                            Name = "Charlie",
                            Weight = 22
                        },
                        new
                        {
                            Id = new Guid("d45fb3de-21f0-445f-a274-a6afd77f71f9"),
                            Breed = "Golden Retriever",
                            LikesToPlay = true,
                            Name = "Coco",
                            Weight = 27
                        },
                        new
                        {
                            Id = new Guid("de4399f7-31fc-45b3-8231-622bb73d7571"),
                            Breed = "German Shepherd",
                            LikesToPlay = true,
                            Name = "Milo",
                            Weight = 28
                        },
                        new
                        {
                            Id = new Guid("4b1af5a1-9105-4d06-9582-e33d4f896071"),
                            Breed = "Poodle",
                            LikesToPlay = true,
                            Name = "Rosie",
                            Weight = 14
                        },
                        new
                        {
                            Id = new Guid("acb8c559-d746-4506-b65d-150bfce00c08"),
                            Breed = "Beagle",
                            LikesToPlay = true,
                            Name = "Zeus",
                            Weight = 20
                        },
                        new
                        {
                            Id = new Guid("34f7eb8d-240a-4c41-871a-5cb04bdf4971"),
                            Breed = "Labrador",
                            LikesToPlay = true,
                            Name = "Sadie",
                            Weight = 25
                        },
                        new
                        {
                            Id = new Guid("5eac3c12-38dd-42d6-a7fd-ca754f4ce088"),
                            Breed = "Golden Retriever",
                            LikesToPlay = true,
                            Name = "Duke",
                            Weight = 29
                        },
                        new
                        {
                            Id = new Guid("31edc8b9-a070-440f-b865-882eb1eeb761"),
                            Breed = "German Shepherd",
                            LikesToPlay = true,
                            Name = "Chloe",
                            Weight = 31
                        },
                        new
                        {
                            Id = new Guid("711da70c-0e55-4a16-91b6-be7d42abf6c4"),
                            Breed = "Poodle",
                            LikesToPlay = true,
                            Name = "Oliver",
                            Weight = 16
                        },
                        new
                        {
                            Id = new Guid("a20163b5-c42a-479d-ab85-6d4038cffc48"),
                            Breed = "Beagle",
                            LikesToPlay = true,
                            Name = "Ruby",
                            Weight = 19
                        },
                        new
                        {
                            Id = new Guid("3b57448c-e2a1-4832-b7ca-d508afe7fecf"),
                            Breed = "Labrador",
                            LikesToPlay = true,
                            Name = "Thor",
                            Weight = 23
                        },
                        new
                        {
                            Id = new Guid("01fdb11b-3e33-457d-bd6c-7a265aa180a1"),
                            Breed = "Golden Retriever",
                            LikesToPlay = true,
                            Name = "Pepper",
                            Weight = 26
                        },
                        new
                        {
                            Id = new Guid("7c774337-8c9c-4c05-a38e-c58743ef4eb2"),
                            Breed = "Labrador",
                            LikesToPlay = true,
                            Name = "Cooper",
                            Weight = 24
                        },
                        new
                        {
                            Id = new Guid("e9692de1-4666-432c-8854-7eb56e8dec43"),
                            Breed = "Golden Retriever",
                            LikesToPlay = true,
                            Name = "Mia",
                            Weight = 29
                        },
                        new
                        {
                            Id = new Guid("8e430d5b-3730-48b4-aad3-125c1eb22608"),
                            Breed = "German Shepherd",
                            LikesToPlay = true,
                            Name = "Tucker",
                            Weight = 32
                        },
                        new
                        {
                            Id = new Guid("e6ec245c-e0d0-44bf-925e-10e72b6fbd6f"),
                            Breed = "Poodle",
                            LikesToPlay = true,
                            Name = "Sophie",
                            Weight = 17
                        },
                        new
                        {
                            Id = new Guid("142cce1c-b43e-4d41-b758-503ab5a734fb"),
                            Breed = "Beagle",
                            LikesToPlay = true,
                            Name = "Leo",
                            Weight = 21
                        },
                        new
                        {
                            Id = new Guid("a21276a9-15c1-4b3f-84ed-098eb1bde20e"),
                            Breed = "Labrador",
                            LikesToPlay = true,
                            Name = "Lucy",
                            Weight = 26
                        },
                        new
                        {
                            Id = new Guid("6aaa05ec-0546-4bc5-a368-6249f890822b"),
                            Breed = "Golden Retriever",
                            LikesToPlay = true,
                            Name = "Riley",
                            Weight = 30
                        });
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}

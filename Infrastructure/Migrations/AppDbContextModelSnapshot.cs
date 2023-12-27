﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LikesToPlay")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TypeOfAnimal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("animalCanDo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Birds");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0abfd852-25f9-4bbb-84a3-8842e5ee0475"),
                            Color = "Green",
                            LikesToPlay = true,
                            Name = "Kiwi",
                            TypeOfAnimal = "Bird",
                            animalCanDo = "This animal can fly"
                        },
                        new
                        {
                            Id = new Guid("12223ef9-03b8-44d5-9801-5570fc79b5b4"),
                            Color = "Yellow",
                            LikesToPlay = true,
                            Name = "Sunshine",
                            TypeOfAnimal = "Bird",
                            animalCanDo = "This animal can fly"
                        },
                        new
                        {
                            Id = new Guid("0cd93c3f-66e5-4392-8980-cccc07dda003"),
                            Color = "Blue",
                            LikesToPlay = true,
                            Name = "Sky",
                            TypeOfAnimal = "Bird",
                            animalCanDo = "This animal can fly"
                        },
                        new
                        {
                            Id = new Guid("94572362-3c86-4777-b990-514f0ff85135"),
                            Color = "Red",
                            LikesToPlay = true,
                            Name = "Cherry",
                            TypeOfAnimal = "Bird",
                            animalCanDo = "This animal can fly"
                        },
                        new
                        {
                            Id = new Guid("7f10ba7d-d81b-445d-a1e9-0b4d1ba63441"),
                            Color = "White",
                            LikesToPlay = true,
                            Name = "Snowflake",
                            TypeOfAnimal = "Bird",
                            animalCanDo = "This animal can fly"
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

                    b.Property<string>("TypeOfAnimal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.Property<string>("animalCanDo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            Id = new Guid("afb9ffa5-dd75-4114-a237-5a8c4b36cd65"),
                            Breed = "Siamese",
                            LikesToPlay = true,
                            Name = "Whiskers",
                            TypeOfAnimal = "Cat",
                            Weight = 8,
                            animalCanDo = "This animal can meow"
                        },
                        new
                        {
                            Id = new Guid("30f2d255-cedc-491f-b7e0-d48f3e36504f"),
                            Breed = "Persian",
                            LikesToPlay = true,
                            Name = "Mittens",
                            TypeOfAnimal = "Cat",
                            Weight = 10,
                            animalCanDo = "This animal can meow"
                        },
                        new
                        {
                            Id = new Guid("2f55c8c0-7cc0-4d28-b666-fce48b2ec835"),
                            Breed = "Maine Coon",
                            LikesToPlay = true,
                            Name = "Shadow",
                            TypeOfAnimal = "Cat",
                            Weight = 15,
                            animalCanDo = "This animal can meow"
                        },
                        new
                        {
                            Id = new Guid("a0c15204-7700-4d23-816a-a0d8081ee01f"),
                            Breed = "Ragdoll",
                            LikesToPlay = true,
                            Name = "Smokey",
                            TypeOfAnimal = "Cat",
                            Weight = 12,
                            animalCanDo = "This animal can meow"
                        },
                        new
                        {
                            Id = new Guid("d7b5f156-4159-4cba-a632-aedfe31980cd"),
                            Breed = "Bengal",
                            LikesToPlay = true,
                            Name = "Tiger",
                            TypeOfAnimal = "Cat",
                            Weight = 11,
                            animalCanDo = "This animal can meow"
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

                    b.Property<string>("TypeOfAnimal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.Property<string>("animalCanDo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("40dc7260-e136-4f4c-980b-970057c3ab8e"),
                            Breed = "Labrador",
                            LikesToPlay = true,
                            Name = "Luna",
                            TypeOfAnimal = "Dog",
                            Weight = 25,
                            animalCanDo = "This animal can bark"
                        },
                        new
                        {
                            Id = new Guid("a4c56d9e-f867-4297-aae7-5d13eb4d404f"),
                            Breed = "Golden Retriever",
                            LikesToPlay = true,
                            Name = "Max",
                            TypeOfAnimal = "Dog",
                            Weight = 28,
                            animalCanDo = "This animal can bark"
                        },
                        new
                        {
                            Id = new Guid("0c3ce72e-dcad-4622-be37-211105d3787c"),
                            Breed = "German Shepherd",
                            LikesToPlay = true,
                            Name = "Bella",
                            TypeOfAnimal = "Dog",
                            Weight = 30,
                            animalCanDo = "This animal can bark"
                        },
                        new
                        {
                            Id = new Guid("fa5429f9-f296-4170-aec1-4be61529b967"),
                            Breed = "Poodle",
                            LikesToPlay = true,
                            Name = "Rocky",
                            TypeOfAnimal = "Dog",
                            Weight = 15,
                            animalCanDo = "This animal can bark"
                        },
                        new
                        {
                            Id = new Guid("5e9ecac1-d1d4-4742-8fa0-d770cd866285"),
                            Breed = "Beagle",
                            LikesToPlay = true,
                            Name = "Daisy",
                            TypeOfAnimal = "Dog",
                            Weight = 18,
                            animalCanDo = "This animal can bark"
                        },
                        new
                        {
                            Id = new Guid("f851acbe-935c-4137-a020-7aea7b7a7539"),
                            Breed = "Golden Retriever",
                            LikesToPlay = true,
                            Name = "Riley",
                            TypeOfAnimal = "Dog",
                            Weight = 30,
                            animalCanDo = "This animal can bark"
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("33175bd8-2840-4d6e-aad6-7be16c28ebd3"),
                            PasswordHash = "$2a$11$LdZPvw/kxCMauiYsjWi8r.WItTaSCtNjNn3CI7oBpCqvDhxpdav5m",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Domain.Models.UserBird", b =>
                {
                    b.Property<Guid>("BirdId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("BirdId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserBird");
                });

            modelBuilder.Entity("Domain.Models.UserCat", b =>
                {
                    b.Property<Guid>("CatId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("CatId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCat");
                });

            modelBuilder.Entity("Domain.Models.UserDog", b =>
                {
                    b.Property<Guid>("DogId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("DogId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserDog");
                });

            modelBuilder.Entity("Domain.Models.UserBird", b =>
                {
                    b.HasOne("Domain.Models.Bird", "Bird")
                        .WithMany("UserBird")
                        .HasForeignKey("BirdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("UserBird")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bird");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.UserCat", b =>
                {
                    b.HasOne("Domain.Models.Cat", "Cat")
                        .WithMany("UserCat")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("UserCat")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.UserDog", b =>
                {
                    b.HasOne("Domain.Models.Dog", "Dog")
                        .WithMany("UserDog")
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("UserDog")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.Bird", b =>
                {
                    b.Navigation("UserBird");
                });

            modelBuilder.Entity("Domain.Models.Cat", b =>
                {
                    b.Navigation("UserCat");
                });

            modelBuilder.Entity("Domain.Models.Dog", b =>
                {
                    b.Navigation("UserDog");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("UserBird");

                    b.Navigation("UserCat");

                    b.Navigation("UserDog");
                });
#pragma warning restore 612, 618
        }
    }
}

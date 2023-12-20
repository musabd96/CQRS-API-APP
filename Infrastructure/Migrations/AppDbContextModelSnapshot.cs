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
                            Id = new Guid("db156db9-9253-412a-bb8f-a2e44c3e2d7f"),
                            Color = "Green",
                            LikesToPlay = true,
                            Name = "Kiwi",
                            TypeOfAnimal = "Bird",
                            animalCanDo = "This animal can fly"
                        },
                        new
                        {
                            Id = new Guid("3bf8699a-cff9-4231-9cc6-a2669418a10c"),
                            Color = "Yellow",
                            LikesToPlay = true,
                            Name = "Sunshine",
                            TypeOfAnimal = "Bird",
                            animalCanDo = "This animal can fly"
                        },
                        new
                        {
                            Id = new Guid("c7b66443-e962-4ffc-93e6-91995023b16f"),
                            Color = "Blue",
                            LikesToPlay = true,
                            Name = "Sky",
                            TypeOfAnimal = "Bird",
                            animalCanDo = "This animal can fly"
                        },
                        new
                        {
                            Id = new Guid("755efddb-afec-48d8-8977-0494741aaa9e"),
                            Color = "Red",
                            LikesToPlay = true,
                            Name = "Cherry",
                            TypeOfAnimal = "Bird",
                            animalCanDo = "This animal can fly"
                        },
                        new
                        {
                            Id = new Guid("24cc2a8d-4c11-4216-b6eb-8508a35d5262"),
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
                            Id = new Guid("c2acbc1b-7fdc-4e2e-92be-8a2a2336168e"),
                            Breed = "Siamese",
                            LikesToPlay = true,
                            Name = "Whiskers",
                            TypeOfAnimal = "Cat",
                            Weight = 8,
                            animalCanDo = "This animal can meow"
                        },
                        new
                        {
                            Id = new Guid("7279e1c1-9dc9-4787-93d7-e2572f7811eb"),
                            Breed = "Persian",
                            LikesToPlay = true,
                            Name = "Mittens",
                            TypeOfAnimal = "Cat",
                            Weight = 10,
                            animalCanDo = "This animal can meow"
                        },
                        new
                        {
                            Id = new Guid("c197b233-3249-48eb-b016-74ba090ba989"),
                            Breed = "Maine Coon",
                            LikesToPlay = true,
                            Name = "Shadow",
                            TypeOfAnimal = "Cat",
                            Weight = 15,
                            animalCanDo = "This animal can meow"
                        },
                        new
                        {
                            Id = new Guid("13537654-700b-47ca-98d0-e31e22bf6bb6"),
                            Breed = "Ragdoll",
                            LikesToPlay = true,
                            Name = "Smokey",
                            TypeOfAnimal = "Cat",
                            Weight = 12,
                            animalCanDo = "This animal can meow"
                        },
                        new
                        {
                            Id = new Guid("9d53e078-f54b-48a9-ad15-4dd456f56079"),
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
                            Id = new Guid("c48537b3-3aab-4503-bf67-1c197c076ac3"),
                            Breed = "Labrador",
                            LikesToPlay = true,
                            Name = "Luna",
                            TypeOfAnimal = "Dog",
                            Weight = 25,
                            animalCanDo = "This animal can bark"
                        },
                        new
                        {
                            Id = new Guid("cc756eca-7302-4ffa-9c5a-d354b9f76ca1"),
                            Breed = "Golden Retriever",
                            LikesToPlay = true,
                            Name = "Max",
                            TypeOfAnimal = "Dog",
                            Weight = 28,
                            animalCanDo = "This animal can bark"
                        },
                        new
                        {
                            Id = new Guid("4a843d7a-1eca-449c-8d7c-ba5f168ebf35"),
                            Breed = "German Shepherd",
                            LikesToPlay = true,
                            Name = "Bella",
                            TypeOfAnimal = "Dog",
                            Weight = 30,
                            animalCanDo = "This animal can bark"
                        },
                        new
                        {
                            Id = new Guid("e59de086-1975-4c19-9efe-f38c075bb74b"),
                            Breed = "Poodle",
                            LikesToPlay = true,
                            Name = "Rocky",
                            TypeOfAnimal = "Dog",
                            Weight = 15,
                            animalCanDo = "This animal can bark"
                        },
                        new
                        {
                            Id = new Guid("4779a5c5-9ede-4d35-ae98-bf552a650d3b"),
                            Breed = "Beagle",
                            LikesToPlay = true,
                            Name = "Daisy",
                            TypeOfAnimal = "Dog",
                            Weight = 18,
                            animalCanDo = "This animal can bark"
                        },
                        new
                        {
                            Id = new Guid("a79ab4c5-a5e8-4404-87f9-bf3c15cce925"),
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

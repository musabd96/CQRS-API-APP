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
    [Migration("20231217133124_SeadAnimal")]
    partial class SeadAnimal
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

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

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
                            Id = new Guid("91fe78b0-8c74-4590-9dad-7e03e5a9c100"),
                            Color = "Green",
                            LikesToPlay = true,
                            Name = "Kiwi"
                        },
                        new
                        {
                            Id = new Guid("23e09afa-ff7e-49bf-83da-500848e6760c"),
                            Color = "Yellow",
                            LikesToPlay = true,
                            Name = "Sunshine"
                        },
                        new
                        {
                            Id = new Guid("73a50dc3-967e-480f-be01-1ced8ad6b999"),
                            Color = "Blue",
                            LikesToPlay = true,
                            Name = "Sky"
                        },
                        new
                        {
                            Id = new Guid("802a5917-a6f9-4275-8d62-12e8da00e6cf"),
                            Color = "Red",
                            LikesToPlay = true,
                            Name = "Cherry"
                        },
                        new
                        {
                            Id = new Guid("e4c917ea-505b-4a9f-bf82-416718c60ec0"),
                            Color = "White",
                            LikesToPlay = true,
                            Name = "Snowflake"
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
                            Id = new Guid("a722f242-fb7c-46dd-888f-24dee483b99d"),
                            Breed = "Siamese",
                            LikesToPlay = true,
                            Name = "Whiskers",
                            Weight = 8
                        },
                        new
                        {
                            Id = new Guid("6a57904f-57be-440b-85ac-f83d4a98555a"),
                            Breed = "Persian",
                            LikesToPlay = true,
                            Name = "Mittens",
                            Weight = 10
                        },
                        new
                        {
                            Id = new Guid("7bca437b-87f8-4723-a412-c4a0cf89d01d"),
                            Breed = "Maine Coon",
                            LikesToPlay = true,
                            Name = "Shadow",
                            Weight = 15
                        },
                        new
                        {
                            Id = new Guid("33b32911-b1d6-49c5-9a81-24f4966c726b"),
                            Breed = "Ragdoll",
                            LikesToPlay = true,
                            Name = "Smokey",
                            Weight = 12
                        },
                        new
                        {
                            Id = new Guid("5755190b-9cad-4d29-94dc-b579c6cbbffa"),
                            Breed = "Bengal",
                            LikesToPlay = true,
                            Name = "Tiger",
                            Weight = 11
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
                            Id = new Guid("b6ba1578-cc05-4342-aef1-5926e6f91f59"),
                            Breed = "Labrador",
                            LikesToPlay = true,
                            Name = "Luna",
                            Weight = 25
                        },
                        new
                        {
                            Id = new Guid("2cfe4516-598b-4526-9355-5634e140869f"),
                            Breed = "Golden Retriever",
                            LikesToPlay = true,
                            Name = "Max",
                            Weight = 28
                        },
                        new
                        {
                            Id = new Guid("694f492d-032e-4324-8ed8-9e42f8c5c8a7"),
                            Breed = "German Shepherd",
                            LikesToPlay = true,
                            Name = "Bella",
                            Weight = 30
                        },
                        new
                        {
                            Id = new Guid("625a85d2-9109-4c31-84de-88543dc37a37"),
                            Breed = "Poodle",
                            LikesToPlay = true,
                            Name = "Rocky",
                            Weight = 15
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
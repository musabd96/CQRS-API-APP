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

                    b.Property<string>("Breed")
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
                            Id = new Guid("427af8ea-c3f2-41dd-909c-e5adc46f5f21"),
                            Breed = "",
                            LikesToPlay = true,
                            Name = "Alex"
                        },
                        new
                        {
                            Id = new Guid("61b1cc37-1746-4407-9ace-deabd55afeac"),
                            Breed = "",
                            LikesToPlay = true,
                            Name = "Sofia"
                        },
                        new
                        {
                            Id = new Guid("bb45d76f-64dc-4e40-8fb1-7e0a5bae9fa4"),
                            Breed = "",
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

                    b.HasKey("Id");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1e95ff9b-04ad-4de0-91c2-9d171733d50f"),
                            Breed = "Siamese",
                            LikesToPlay = true,
                            Name = "Steven"
                        },
                        new
                        {
                            Id = new Guid("c739c729-d572-41dd-855b-ecb72eb7f1a2"),
                            Breed = "Persian",
                            LikesToPlay = true,
                            Name = "Alpin"
                        },
                        new
                        {
                            Id = new Guid("474a171b-1595-4f20-809b-aaf13249a3e9"),
                            Breed = "Maine Coon",
                            LikesToPlay = true,
                            Name = "Nelson"
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

                    b.HasKey("Id");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4656edda-5908-4575-9dcc-9625775116f0"),
                            Breed = "Labrador",
                            LikesToPlay = true,
                            Name = "Björn"
                        },
                        new
                        {
                            Id = new Guid("5372d336-b199-40c1-8ec8-d67d23b50274"),
                            Breed = "Golden Retriever",
                            LikesToPlay = true,
                            Name = "Patrik"
                        },
                        new
                        {
                            Id = new Guid("12d7c360-1764-4ebc-994e-182f2a458f53"),
                            Breed = "German Shepherd",
                            LikesToPlay = true,
                            Name = "Alfred"
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

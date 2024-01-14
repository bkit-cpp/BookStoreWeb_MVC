﻿// <auto-generated />
using System;
using BookStoreMVCWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStoreMVCWeb.Migrations
{
    [DbContext(typeof(BookStoreMVCWebContext))]
    [Migration("20231206034950_UpdateUrlImg")]
    partial class UpdateUrlImg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookStoreMVCWeb.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IBNS")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Astrid Lindgren",
                            DatePublished = new DateTime(2013, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            IBNS = "9789129688313",
                            ImageUrl = "/themes/images/tab-item1.jpg",
                            Language = "Swedish",
                            Price = 139,
                            Title = "Bröderna Lejonhjärta"
                        },
                        new
                        {
                            Id = 6,
                            Author = "J. R. R. Tolkien",
                            DatePublished = new DateTime(1991, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            IBNS = "9780261102354",
                            ImageUrl = "/themes/images/tab-item6.jpg",
                            Language = "English",
                            Price = 100,
                            Title = "The Fellowship of the Ring"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Dennis Lehane",
                            DatePublished = new DateTime(2011, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            IBNS = "9780062068408",
                            ImageUrl = "/themes/images/tab-item2.jpg",
                            Language = "English",
                            Price = 91,
                            Title = "Mystic River"
                        },
                        new
                        {
                            Id = 5,
                            Author = "John Steinbeck",
                            DatePublished = new DateTime(1994, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            IBNS = "9780062068408",
                            ImageUrl = "/themes/images/tab-item5.jpg",
                            Language = "English",
                            Price = 166,
                            Title = "Of Mice and Men"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Ernest Hemingway",
                            DatePublished = new DateTime(1994, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            IBNS = "9780062068408",
                            ImageUrl = "/themes/images/tab-item3.jpg",
                            Language = "English",
                            Price = 84,
                            Title = "The Old Man and the Sea"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Cormac McCarthy",
                            DatePublished = new DateTime(2007, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            IBNS = "9780307386458",
                            ImageUrl = "/themes/images/tab-item7.jpg",
                            Language = "English",
                            Price = 95,
                            Title = "The Road"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStore.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    [Migration("20191125075929_Update_Model")]
    partial class Update_Model
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1");

            modelBuilder.Entity("BookStore.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Genre1",
                            Price = 20m,
                            PublishDate = new DateTime(2012, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Book1"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Genre2",
                            Price = 30m,
                            PublishDate = new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Book2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

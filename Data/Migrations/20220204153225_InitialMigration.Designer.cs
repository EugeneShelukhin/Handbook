﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using handbook.Data;

#nullable disable

namespace handbook.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220204153225_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("handbook.Data.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(4096)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "This is the Post1 content.",
                            Title = "Post1"
                        },
                        new
                        {
                            Id = 2,
                            Content = "This is the Post2 content.",
                            Title = "Post2"
                        },
                        new
                        {
                            Id = 3,
                            Content = "This is the Post3 content.",
                            Title = "Post3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

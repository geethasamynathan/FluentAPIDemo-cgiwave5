﻿// <auto-generated />
using FluentAPIDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FluentAPIDemo.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20221003041212_uniqueconstraintaddedtocategorytable")]
    partial class uniqueconstraintaddedtocategorytable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FluentAPIDemo.Models.Category", b =>
                {
                    b.Property<byte>("CategoryId")
                        .HasColumnType("tinyint");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CategoryId");

                    b.HasAlternateKey("CategoryName")
                        .HasName("uq_categoryName");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FluentAPIDemo.Models.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte>("CategoryId")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("Price")
                        .HasColumnType("Numeric(8)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("QuantityAvailable")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FluentAPIDemo.Models.Product", b =>
                {
                    b.HasOne("FluentAPIDemo.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

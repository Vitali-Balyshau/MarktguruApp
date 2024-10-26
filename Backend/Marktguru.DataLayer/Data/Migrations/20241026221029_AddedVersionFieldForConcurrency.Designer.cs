﻿// <auto-generated />
using System;
using Marktguru.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Marktguru.DataLayer.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241026221029_AddedVersionFieldForConcurrency")]
    partial class AddedVersionFieldForConcurrency
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Marktguru.DataLayer.DataEntities.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductModels");
                });
#pragma warning restore 612, 618
        }
    }
}
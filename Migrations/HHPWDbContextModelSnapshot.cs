﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HHPW.Migrations
{
    [DbContext(typeof(HHPWDbContext))]
    partial class HHPWDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HHPW.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pizza",
                            price = 10
                        },
                        new
                        {
                            Id = 2,
                            Name = "Wangs",
                            price = 20
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ands",
                            price = 15
                        },
                        new
                        {
                            Id = 4,
                            Name = "Thangs",
                            price = 25
                        });
                });

            modelBuilder.Entity("HHPW.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("OrderType")
                        .HasColumnType("text");

                    b.Property<string>("PaymentType")
                        .HasColumnType("text");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<int>("Tip")
                        .HasColumnType("integer");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric");

                    b.Property<int>("userId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2024, 4, 18, 2, 7, 3, 456, DateTimeKind.Local).AddTicks(4075),
                            Email = "john@example.com",
                            IsOpen = true,
                            Name = "John Doe",
                            OrderType = "Phone",
                            PaymentType = "Check",
                            Phone = 1234567890L,
                            Tip = 5,
                            Total = 50m,
                            userId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 4, 19, 2, 7, 3, 458, DateTimeKind.Local).AddTicks(5729),
                            Email = "jane@example.com",
                            IsOpen = false,
                            Name = "Jane Smith",
                            OrderType = "In-Person",
                            PaymentType = "Debit",
                            Phone = 9876543210L,
                            Tip = 3,
                            Total = 30m,
                            userId = 2
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 4, 20, 2, 7, 3, 458, DateTimeKind.Local).AddTicks(5764),
                            Email = "alice@example.com",
                            IsOpen = true,
                            Name = "Alice Johnson",
                            OrderType = "Phone",
                            PaymentType = "Cash",
                            Phone = 5551234567L,
                            Tip = 4,
                            Total = 45m,
                            userId = 3
                        });
                });

            modelBuilder.Entity("HHPW.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 0,
                            ItemId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 0,
                            ItemId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 3,
                            Amount = 0,
                            ItemId = 3,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 4,
                            Amount = 0,
                            ItemId = 4,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 5,
                            Amount = 0,
                            ItemId = 1,
                            OrderId = 3
                        });
                });

            modelBuilder.Entity("HHPW.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "John",
                            Uid = "101"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jane",
                            Uid = "102"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Alice",
                            Uid = "103"
                        });
                });

            modelBuilder.Entity("HHPW.Models.OrderItem", b =>
                {
                    b.HasOne("HHPW.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}

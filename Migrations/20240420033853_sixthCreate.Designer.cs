﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HHPW.Migrations
{
    [DbContext(typeof(HHPWDbContext))]
    [Migration("20240420033853_sixthCreate")]
    partial class sixthCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Name = "Widget",
                            price = 10
                        },
                        new
                        {
                            Id = 2,
                            Name = "Gadget",
                            price = 20
                        },
                        new
                        {
                            Id = 3,
                            Name = "Thingamajig",
                            price = 15
                        },
                        new
                        {
                            Id = 4,
                            Name = "Doohickey",
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

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("OrderType")
                        .HasColumnType("text");

                    b.Property<string>("PaymentType")
                        .HasColumnType("text");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

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
                            Date = new DateTime(2024, 4, 17, 22, 38, 52, 517, DateTimeKind.Local).AddTicks(9759),
                            Email = "john@example.com",
                            Name = "John Doe",
                            OrderType = "Online",
                            PaymentType = "Credit Card",
                            Phone = 1234567890L,
                            Status = true,
                            Tip = 5,
                            Total = 50m,
                            userId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 4, 18, 22, 38, 52, 519, DateTimeKind.Local).AddTicks(6506),
                            Email = "jane@example.com",
                            Name = "Jane Smith",
                            OrderType = "In-store",
                            PaymentType = "PayPal",
                            Phone = 9876543210L,
                            Status = false,
                            Tip = 3,
                            Total = 30m,
                            userId = 2
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 4, 19, 22, 38, 52, 519, DateTimeKind.Local).AddTicks(6528),
                            Email = "alice@example.com",
                            Name = "Alice Johnson",
                            OrderType = "Delivery",
                            PaymentType = "Cash",
                            Phone = 5551234567L,
                            Status = true,
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

                    b.HasIndex("OrderId");

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

            modelBuilder.Entity("ItemOrderItem", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("integer");

                    b.Property<int>("OrdersId")
                        .HasColumnType("integer");

                    b.HasKey("ItemsId", "OrdersId");

                    b.HasIndex("OrdersId");

                    b.ToTable("ItemOrderItem");
                });

            modelBuilder.Entity("HHPW.Models.OrderItem", b =>
                {
                    b.HasOne("HHPW.Models.Order", null)
                        .WithMany("Orders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ItemOrderItem", b =>
                {
                    b.HasOne("HHPW.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HHPW.Models.OrderItem", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HHPW.Models.Order", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}

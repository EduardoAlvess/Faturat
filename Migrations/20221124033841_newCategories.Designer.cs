﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCC.Db;

#nullable disable

namespace TCC.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221124033841_newCategories")]
    partial class newCategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TCC.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Balance")
                        .HasColumnType("double");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<int>("IconId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Balance = 2000.0,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1588),
                            IconId = 1,
                            Name = "Conta corrente",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Balance = 233.33000000000001,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1589),
                            IconId = 2,
                            Name = "Conta PJ",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("TCC.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IconId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasDiscriminator<string>("Type").HasValue("Category");
                });

            modelBuilder.Entity("TCC.Models.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<double>("CurrentBalance")
                        .HasColumnType("double");

                    b.Property<double>("FinalBalance")
                        .HasColumnType("double");

                    b.Property<DateTime>("FinalDate")
                        .HasColumnType("datetime");

                    b.Property<int>("IconId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Goals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1925),
                            CurrentAmount = 400.0,
                            FinalAmount = 2000.0,
                            FinalDate = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IconId = 1,
                            Name = "Viagem",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1926),
                            CurrentAmount = 12000.32,
                            FinalAmount = 35000.720000000001,
                            FinalDate = new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IconId = 2,
                            Name = "Carro",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("TCC.Models.Icon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Icons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageName = "img1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            ImageName = "img2.jpg"
                        });
                });

            modelBuilder.Entity("TCC.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Transactions");

                    b.HasDiscriminator<string>("Type").HasValue("Transaction");
                });

            modelBuilder.Entity("TCC.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1231),
                            Name = "Eduardo",
                            Password = "12345",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1242),
                            Name = "Paulo",
                            Password = "54321",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("TCC.Models.Expense", b =>
                {
                    b.HasBaseType("TCC.Models.Transaction");

                    b.Property<bool>("isPaid")
                        .HasColumnType("tinyint(1)");

                    b.HasDiscriminator().HasValue("Expense");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            CategoryId = 1,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1890),
                            Description = "Mercado",
                            TransactionDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1891),
                            UserId = 1,
                            Value = 250.0,
                            isDeleted = false,
                            isPaid = true
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 2,
                            CategoryId = 2,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1893),
                            Description = "Alaminuta",
                            TransactionDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1893),
                            UserId = 2,
                            Value = 172.34999999999999,
                            isDeleted = false,
                            isPaid = false
                        });
                });

            modelBuilder.Entity("TCC.Models.ExpenseCategory", b =>
                {
                    b.HasBaseType("TCC.Models.Category");

                    b.HasDiscriminator().HasValue("ExpenseCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1634),
                            Description = "Gym",
                            IconId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1636),
                            Description = "Clothing",
                            IconId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1637),
                            Description = "Education",
                            IconId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1637),
                            Description = "Pet",
                            IconId = 4
                        },
                        new
                        {
                            Id = 5,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1638),
                            Description = "Electronics",
                            IconId = 5
                        },
                        new
                        {
                            Id = 6,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1639),
                            Description = "Health",
                            IconId = 6
                        },
                        new
                        {
                            Id = 7,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1639),
                            Description = "Home",
                            IconId = 7
                        },
                        new
                        {
                            Id = 8,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1640),
                            Description = "Taxes",
                            IconId = 8
                        },
                        new
                        {
                            Id = 9,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1641),
                            Description = "Leisure",
                            IconId = 9
                        },
                        new
                        {
                            Id = 10,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1641),
                            Description = "Others",
                            IconId = 10
                        },
                        new
                        {
                            Id = 11,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1642),
                            Description = "Restaurant",
                            IconId = 11
                        },
                        new
                        {
                            Id = 12,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1643),
                            Description = "Services",
                            IconId = 12
                        },
                        new
                        {
                            Id = 13,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1644),
                            Description = "Supermarket",
                            IconId = 13
                        },
                        new
                        {
                            Id = 14,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1645),
                            Description = "Transportation",
                            IconId = 14
                        },
                        new
                        {
                            Id = 15,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1645),
                            Description = "Travel",
                            IconId = 15
                        });
                });

            modelBuilder.Entity("TCC.Models.Income", b =>
                {
                    b.HasBaseType("TCC.Models.Transaction");

                    b.Property<bool>("isReceived")
                        .HasColumnType("tinyint(1)");

                    b.HasDiscriminator().HasValue("Income");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            AccountId = 1,
                            CategoryId = 3,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1908),
                            Description = "Salário",
                            TransactionDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1909),
                            UserId = 1,
                            Value = 2000.0,
                            isDeleted = false,
                            isReceived = true
                        },
                        new
                        {
                            Id = 4,
                            AccountId = 2,
                            CategoryId = 4,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1910),
                            Description = "Premio",
                            TransactionDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1910),
                            UserId = 2,
                            Value = 13.75,
                            isDeleted = false,
                            isReceived = false
                        });
                });

            modelBuilder.Entity("TCC.Models.IncomeCategory", b =>
                {
                    b.HasBaseType("TCC.Models.Category");

                    b.HasDiscriminator().HasValue("IncomeCategory");

                    b.HasData(
                        new
                        {
                            Id = 16,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1869),
                            Description = "Awards",
                            IconId = 16
                        },
                        new
                        {
                            Id = 17,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1870),
                            Description = "Gift",
                            IconId = 17
                        },
                        new
                        {
                            Id = 18,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1873),
                            Description = "Investments",
                            IconId = 18
                        },
                        new
                        {
                            Id = 19,
                            CreationDate = new DateTime(2022, 11, 24, 0, 38, 41, 113, DateTimeKind.Local).AddTicks(1874),
                            Description = "Salary",
                            IconId = 19
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

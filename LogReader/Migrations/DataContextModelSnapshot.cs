﻿// <auto-generated />
using System;
using LogReader.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LogReader.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LogReader.LogData", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogId"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ErrorType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LogId");

                    b.ToTable("Log");

                    b.HasData(
                        new
                        {
                            LogId = 1,
                            DateTime = new DateTime(2023, 10, 11, 12, 34, 56, 0, DateTimeKind.Unspecified),
                            Description = "User 'John' logged in.",
                            ErrorType = "INFO"
                        },
                        new
                        {
                            LogId = 2,
                            DateTime = new DateTime(2023, 10, 11, 13, 45, 2, 0, DateTimeKind.Unspecified),
                            Description = "Database connection failed.",
                            ErrorType = "ERROR"
                        },
                        new
                        {
                            LogId = 3,
                            DateTime = new DateTime(2023, 10, 11, 14, 20, 30, 0, DateTimeKind.Unspecified),
                            Description = "User 'Alice' logged in.",
                            ErrorType = "INFO"
                        },
                        new
                        {
                            LogId = 4,
                            DateTime = new DateTime(2023, 10, 11, 15, 10, 15, 0, DateTimeKind.Unspecified),
                            Description = "User 'Bob' logged in.",
                            ErrorType = "INFO"
                        },
                        new
                        {
                            LogId = 5,
                            DateTime = new DateTime(2023, 10, 11, 15, 30, 45, 0, DateTimeKind.Unspecified),
                            Description = "Disk space is running low.",
                            ErrorType = "WARNING"
                        },
                        new
                        {
                            LogId = 6,
                            DateTime = new DateTime(2023, 10, 11, 16, 5, 12, 0, DateTimeKind.Unspecified),
                            Description = "Application crashed unexpectedly.",
                            ErrorType = "ERROR"
                        },
                        new
                        {
                            LogId = 7,
                            DateTime = new DateTime(2023, 10, 11, 16, 45, 22, 0, DateTimeKind.Unspecified),
                            Description = "User 'Eve' logged in.",
                            ErrorType = "INFO"
                        },
                        new
                        {
                            LogId = 8,
                            DateTime = new DateTime(2023, 10, 11, 17, 12, 55, 0, DateTimeKind.Unspecified),
                            Description = "User 'Charlie' logged in.",
                            ErrorType = "INFO"
                        },
                        new
                        {
                            LogId = 9,
                            DateTime = new DateTime(2023, 10, 11, 17, 25, 10, 0, DateTimeKind.Unspecified),
                            Description = "Server load is high.",
                            ErrorType = "WARNING"
                        },
                        new
                        {
                            LogId = 10,
                            DateTime = new DateTime(2023, 10, 11, 17, 55, 40, 0, DateTimeKind.Unspecified),
                            Description = "Out of memory error.",
                            ErrorType = "ERROR"
                        },
                        new
                        {
                            LogId = 11,
                            DateTime = new DateTime(2023, 10, 11, 18, 30, 1, 0, DateTimeKind.Unspecified),
                            Description = "User 'David' logged in.",
                            ErrorType = "INFO"
                        },
                        new
                        {
                            LogId = 12,
                            DateTime = new DateTime(2023, 10, 11, 18, 45, 25, 0, DateTimeKind.Unspecified),
                            Description = "Network connection lost.",
                            ErrorType = "WARNING"
                        },
                        new
                        {
                            LogId = 13,
                            DateTime = new DateTime(2023, 10, 11, 19, 15, 50, 0, DateTimeKind.Unspecified),
                            Description = "User 'Frank' logged in.",
                            ErrorType = "INFO"
                        },
                        new
                        {
                            LogId = 14,
                            DateTime = new DateTime(2023, 10, 11, 19, 30, 15, 0, DateTimeKind.Unspecified),
                            Description = "Unauthorized access attempt detected.",
                            ErrorType = "WARNING"
                        },
                        new
                        {
                            LogId = 15,
                            DateTime = new DateTime(2023, 10, 11, 20, 5, 33, 0, DateTimeKind.Unspecified),
                            Description = "File not found.",
                            ErrorType = "ERROR"
                        },
                        new
                        {
                            LogId = 16,
                            DateTime = new DateTime(2023, 10, 11, 20, 25, 49, 0, DateTimeKind.Unspecified),
                            Description = "User 'Grace' logged in.",
                            ErrorType = "INFO"
                        },
                        new
                        {
                            LogId = 17,
                            DateTime = new DateTime(2023, 10, 11, 20, 45, 10, 0, DateTimeKind.Unspecified),
                            Description = "Security breach detected.",
                            ErrorType = "WARNING"
                        },
                        new
                        {
                            LogId = 18,
                            DateTime = new DateTime(2023, 10, 11, 21, 15, 27, 0, DateTimeKind.Unspecified),
                            Description = "Server shutdown initiated.",
                            ErrorType = "ERROR"
                        },
                        new
                        {
                            LogId = 19,
                            DateTime = new DateTime(2023, 10, 11, 21, 35, 44, 0, DateTimeKind.Unspecified),
                            Description = "User 'Hannah' logged in.",
                            ErrorType = "INFO"
                        },
                        new
                        {
                            LogId = 20,
                            DateTime = new DateTime(2023, 10, 11, 21, 55, 59, 0, DateTimeKind.Unspecified),
                            Description = "User 'Isabella' logged in.",
                            ErrorType = "INFO"
                        },
                        new
                        {
                            LogId = 21,
                            DateTime = new DateTime(2023, 10, 11, 22, 30, 20, 0, DateTimeKind.Unspecified),
                            Description = "System update in progress.",
                            ErrorType = "WARNING"
                        },
                        new
                        {
                            LogId = 22,
                            DateTime = new DateTime(2023, 10, 11, 22, 55, 45, 0, DateTimeKind.Unspecified),
                            Description = "Data corruption detected.",
                            ErrorType = "ERROR"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

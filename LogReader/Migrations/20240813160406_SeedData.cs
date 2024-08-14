using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LogReader.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Log",
                columns: new[] { "LogId", "DateTime", "Description", "ErrorType" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 11, 12, 34, 56, 0, DateTimeKind.Unspecified), "User 'John' logged in.", "INFO" },
                    { 2, new DateTime(2023, 10, 11, 13, 45, 2, 0, DateTimeKind.Unspecified), "Database connection failed.", "ERROR" },
                    { 3, new DateTime(2023, 10, 11, 14, 20, 30, 0, DateTimeKind.Unspecified), "User 'Alice' logged in.", "INFO" },
                    { 4, new DateTime(2023, 10, 11, 15, 10, 15, 0, DateTimeKind.Unspecified), "User 'Bob' logged in.", "INFO" },
                    { 5, new DateTime(2023, 10, 11, 15, 30, 45, 0, DateTimeKind.Unspecified), "Disk space is running low.", "WARNING" },
                    { 6, new DateTime(2023, 10, 11, 16, 5, 12, 0, DateTimeKind.Unspecified), "Application crashed unexpectedly.", "ERROR" },
                    { 7, new DateTime(2023, 10, 11, 16, 45, 22, 0, DateTimeKind.Unspecified), "User 'Eve' logged in.", "INFO" },
                    { 8, new DateTime(2023, 10, 11, 17, 12, 55, 0, DateTimeKind.Unspecified), "User 'Charlie' logged in.", "INFO" },
                    { 9, new DateTime(2023, 10, 11, 17, 25, 10, 0, DateTimeKind.Unspecified), "Server load is high.", "WARNING" },
                    { 10, new DateTime(2023, 10, 11, 17, 55, 40, 0, DateTimeKind.Unspecified), "Out of memory error.", "ERROR" },
                    { 11, new DateTime(2023, 10, 11, 18, 30, 1, 0, DateTimeKind.Unspecified), "User 'David' logged in.", "INFO" },
                    { 12, new DateTime(2023, 10, 11, 18, 45, 25, 0, DateTimeKind.Unspecified), "Network connection lost.", "WARNING" },
                    { 13, new DateTime(2023, 10, 11, 19, 15, 50, 0, DateTimeKind.Unspecified), "User 'Frank' logged in.", "INFO" },
                    { 14, new DateTime(2023, 10, 11, 19, 30, 15, 0, DateTimeKind.Unspecified), "Unauthorized access attempt detected.", "WARNING" },
                    { 15, new DateTime(2023, 10, 11, 20, 5, 33, 0, DateTimeKind.Unspecified), "File not found.", "ERROR" },
                    { 16, new DateTime(2023, 10, 11, 20, 25, 49, 0, DateTimeKind.Unspecified), "User 'Grace' logged in.", "INFO" },
                    { 17, new DateTime(2023, 10, 11, 20, 45, 10, 0, DateTimeKind.Unspecified), "Security breach detected.", "WARNING" },
                    { 18, new DateTime(2023, 10, 11, 21, 15, 27, 0, DateTimeKind.Unspecified), "Server shutdown initiated.", "ERROR" },
                    { 19, new DateTime(2023, 10, 11, 21, 35, 44, 0, DateTimeKind.Unspecified), "User 'Hannah' logged in.", "INFO" },
                    { 20, new DateTime(2023, 10, 11, 21, 55, 59, 0, DateTimeKind.Unspecified), "User 'Isabella' logged in.", "INFO" },
                    { 21, new DateTime(2023, 10, 11, 22, 30, 20, 0, DateTimeKind.Unspecified), "System update in progress.", "WARNING" },
                    { 22, new DateTime(2023, 10, 11, 22, 55, 45, 0, DateTimeKind.Unspecified), "Data corruption detected.", "ERROR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Log",
                keyColumn: "LogId",
                keyValue: 22);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogReader.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LogsData",
                table: "LogsData");

            migrationBuilder.RenameTable(
                name: "LogsData",
                newName: "Log");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Log",
                table: "Log",
                column: "LogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Log",
                table: "Log");

            migrationBuilder.RenameTable(
                name: "Log",
                newName: "LogsData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogsData",
                table: "LogsData",
                column: "LogId");
        }
    }
}

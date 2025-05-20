using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    /// <inheritdoc />
    public partial class RebuildLogTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
    name: "Log");

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    LogId = table.Column<int>(name: "Log_ID", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(type: "varchar(50)", nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    UserId = table.Column<int>(name: "User_ID", nullable: false),
                    CurrentValue = table.Column<string>(type: "varchar(50)", nullable: false),
                    OriginalValue = table.Column<string>(type: "varchar(50)", nullable: false),
                    EntityChanged = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.LogId);
                    table.ForeignKey(
                        name: "FK_Log_User_User_ID",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "TimeStamp",
                table: "Log",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldRowVersion: true);
        }
    }
}

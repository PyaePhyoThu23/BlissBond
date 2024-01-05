using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlissBond.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "MatchDate",
                value: new DateTime(2024, 1, 5, 17, 33, 5, 510, DateTimeKind.Local).AddTicks(331));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "MatchDate",
                value: new DateTime(2024, 1, 5, 16, 47, 41, 383, DateTimeKind.Local).AddTicks(7229));
        }
    }
}

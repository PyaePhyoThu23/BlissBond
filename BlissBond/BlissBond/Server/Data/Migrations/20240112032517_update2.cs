using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlissBond.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "MatchDate",
                value: new DateTime(2024, 1, 12, 11, 25, 16, 693, DateTimeKind.Local).AddTicks(6145));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "MatchDate",
                value: new DateTime(2024, 1, 12, 11, 19, 28, 197, DateTimeKind.Local).AddTicks(9310));
        }
    }
}

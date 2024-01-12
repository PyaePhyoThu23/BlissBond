using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlissBond.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "MatchDate",
                value: new DateTime(2024, 1, 12, 10, 48, 12, 830, DateTimeKind.Local).AddTicks(4135));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "MatchDate",
                value: new DateTime(2024, 1, 5, 17, 33, 5, 510, DateTimeKind.Local).AddTicks(331));
        }
    }
}

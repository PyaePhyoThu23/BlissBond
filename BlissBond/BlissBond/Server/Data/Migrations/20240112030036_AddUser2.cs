using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlissBond.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "MatchDate",
                value: new DateTime(2024, 1, 12, 11, 0, 35, 859, DateTimeKind.Local).AddTicks(7470));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "MatchDate",
                value: new DateTime(2024, 1, 12, 10, 48, 12, 830, DateTimeKind.Local).AddTicks(4135));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlissBond.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class addingusersandmatches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "DateCreated", "DateUpdated", "Email", "FirstName", "Gender", "LastName", "Location", "Nickname", "Password", "Popularity" },
                values: new object[,]
                {
                    { 1, "I am handsome", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "deana@gmail.com", "Dean", "M", "Winchester", "Jurong East", null, "1234", 3.5 },
                    { 2, "I am smart", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "marry@gmail.com", "Marry", "F", "Tan", "Jurong West", "haha", "5678", 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "MatchDate", "MatchStatus", "User1Id", "User2Id", "UserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 16, 47, 41, 383, DateTimeKind.Local).AddTicks(7229), "Just Friend", 1, 2, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

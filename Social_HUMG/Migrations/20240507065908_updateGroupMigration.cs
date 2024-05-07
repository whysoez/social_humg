using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Social_HUMG.Migrations
{
    public partial class updateGroupMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "group_number",
                table: "group",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "room",
                table: "group",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "schedule",
                table: "group",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "teacher",
                table: "group",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "time_end",
                table: "group",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "time_start",
                table: "group",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "group_number",
                table: "group");

            migrationBuilder.DropColumn(
                name: "room",
                table: "group");

            migrationBuilder.DropColumn(
                name: "schedule",
                table: "group");

            migrationBuilder.DropColumn(
                name: "teacher",
                table: "group");

            migrationBuilder.DropColumn(
                name: "time_end",
                table: "group");

            migrationBuilder.DropColumn(
                name: "time_start",
                table: "group");
        }
    }
}

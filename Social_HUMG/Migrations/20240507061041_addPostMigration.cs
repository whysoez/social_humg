using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Social_HUMG.Migrations
{
    public partial class addPostMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    post_parent = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    groupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    group_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    memberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    member_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    create_By = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_By = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    codified_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    delete = table.Column<bool>(type: "bit", nullable: false),
                    state = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");
        }
    }
}

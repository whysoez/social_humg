using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Social_HUMG.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "anser_quiz",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuizId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    anser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    point = table.Column<float>(type: "real", nullable: true),
                    gpa = table.Column<float>(type: "real", nullable: false),
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
                    table.PrimaryKey("PK_anser_quiz", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "assigment_student",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssigmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    point = table.Column<float>(type: "real", nullable: true),
                    file_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gpa = table.Column<float>(type: "real", nullable: false),
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
                    table.PrimaryKey("PK_assigment_student", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "assignment",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    class_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    file_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    due_day = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_assignment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Employee", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "group",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    class_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_group", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "member_group",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    group_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_member_group", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "message",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    class_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    group_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    linkFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createUserImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_message", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "question_quiz",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    quiz_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    option1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    option2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    option3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    option4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_question_quiz", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "quiz",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    class_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_time = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_quiz", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vote",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    class_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_vote", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vote_option",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    vote_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_vote_option", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anser_quiz");

            migrationBuilder.DropTable(
                name: "assigment_student");

            migrationBuilder.DropTable(
                name: "assignment");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "group");

            migrationBuilder.DropTable(
                name: "member_group");

            migrationBuilder.DropTable(
                name: "message");

            migrationBuilder.DropTable(
                name: "question_quiz");

            migrationBuilder.DropTable(
                name: "quiz");

            migrationBuilder.DropTable(
                name: "vote");

            migrationBuilder.DropTable(
                name: "vote_option");
        }
    }
}

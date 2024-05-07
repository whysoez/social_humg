﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Social_HUMG.Data;

#nullable disable

namespace Social_HUMG.Migrations
{
    [DbContext(typeof(SocialDbContext))]
    partial class SocialDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Social_HUMG.Common.Entity.AnswerQuizEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("anser");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("create_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_Date");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit")
                        .HasColumnName("delete");

                    b.Property<float>("Gpa")
                        .HasColumnType("real")
                        .HasColumnName("gpa");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modified_By");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("codified_Date");

                    b.Property<float?>("Point")
                        .HasColumnType("real")
                        .HasColumnName("point");

                    b.Property<Guid>("QuizId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("QuizId");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("anser_quiz");
                });

            modelBuilder.Entity("Social_HUMG.Common.Entity.AssignmentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("class_id");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("create_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_Date");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit")
                        .HasColumnName("delete");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<DateTime>("DueDay")
                        .HasColumnType("datetime2")
                        .HasColumnName("due_day");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("file_name");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modified_By");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("codified_Date");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("assignment");
                });

            modelBuilder.Entity("Social_HUMG.Common.Entity.AssignmentStudentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("AssigmentId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("AssigmentId");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("create_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_Date");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit")
                        .HasColumnName("delete");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("file_name");

                    b.Property<float>("Gpa")
                        .HasColumnType("real")
                        .HasColumnName("gpa");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modified_By");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("codified_Date");

                    b.Property<float?>("Point")
                        .HasColumnType("real")
                        .HasColumnName("point");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.ToTable("assigment_student");
                });

            modelBuilder.Entity("Social_HUMG.Common.Entity.GroupEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("avatar");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("class_id");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("create_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_Date");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit")
                        .HasColumnName("delete");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("GroupNumber")
                        .HasColumnType("int")
                        .HasColumnName("group_number");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modified_By");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("codified_Date");

                    b.Property<string>("Room")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("room");

                    b.Property<string>("Schedule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("schedule");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Teacher")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("teacher");

                    b.Property<DateTime?>("TimeEnd")
                        .HasColumnType("datetime2")
                        .HasColumnName("time_end");

                    b.Property<DateTime?>("TimeStart")
                        .HasColumnType("datetime2")
                        .HasColumnName("time_start");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("group");
                });

            modelBuilder.Entity("Social_HUMG.Common.Entity.MemberGroupEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("create_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_Date");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit")
                        .HasColumnName("delete");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("group_id");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modified_By");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("codified_Date");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.ToTable("member_group");
                });

            modelBuilder.Entity("Social_HUMG.Common.Entity.MessageEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("class_id");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("createUserId");

                    b.Property<string>("CreateUserImage")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("createUserImage");

                    b.Property<string>("CreateUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("createUserName");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("create_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_Date");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit")
                        .HasColumnName("delete");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("fileName");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("group_id");

                    b.Property<string>("LinkFile")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("linkFile");

                    b.Property<string>("MessageContent")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("message");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modified_By");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("codified_Date");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("message");
                });

            modelBuilder.Entity("Social_HUMG.Common.Entity.PostEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("content");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("create_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_Date");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit")
                        .HasColumnName("delete");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("groupId");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("group_name");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("memberId");

                    b.Property<string>("MemberName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("member_name");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modified_By");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("codified_Date");

                    b.Property<Guid>("PostParentId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("post_parent");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("Social_HUMG.Common.Entity.QuestionQuizEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("create_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_Date");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit")
                        .HasColumnName("delete");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modified_By");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("codified_Date");

                    b.Property<string>("Option1")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("option1");

                    b.Property<string>("Option2")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("option2");

                    b.Property<string>("Option3")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("option3");

                    b.Property<string>("Option4")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("option4");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("question");

                    b.Property<Guid>("QuizId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("quiz_id");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("question_quiz");
                });

            modelBuilder.Entity("Social_HUMG.Common.Entity.QuizEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("class_id");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("create_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_Date");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit")
                        .HasColumnName("delete");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("end_time");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modified_By");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("codified_Date");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("start_time");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("quiz");
                });

            modelBuilder.Entity("Social_HUMG.Common.Entity.VoteEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("class_id");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("create_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_Date");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit")
                        .HasColumnName("delete");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modified_By");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("codified_Date");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("vote");
                });

            modelBuilder.Entity("Social_HUMG.Common.Entity.VoteOptionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("create_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_Date");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("data");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit")
                        .HasColumnName("delete");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modified_By");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("codified_Date");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<Guid>("VoteId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("vote_id");

                    b.HasKey("Id");

                    b.ToTable("vote_option");
                });

            modelBuilder.Entity("Social_HUMG.Data.Entities.EmployeeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("create_By");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_Date");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit")
                        .HasColumnName("delete");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modified_By");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("codified_Date");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("state");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}

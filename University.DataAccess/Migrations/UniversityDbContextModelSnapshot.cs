﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using University.DataAccess;

namespace University.DataAccess.Migrations
{
    [DbContext(typeof(UniversityDbContext))]
    partial class UniversityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("University.AppLogic.Models.Assignments", b =>
                {
                    b.Property<Guid>("AssignmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClassroomID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WorkPosted")
                        .HasColumnType("datetime2");

                    b.HasKey("AssignmentID");

                    b.HasIndex("ClassroomID");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("University.AppLogic.Models.Classroom", b =>
                {
                    b.Property<Guid>("ClassroomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClassCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClassroomID");

                    b.ToTable("Classroom");
                });

            modelBuilder.Entity("University.AppLogic.Models.Grades", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HomeworkId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Mark")
                        .HasColumnType("real");

                    b.Property<Guid?>("StudentIdUserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HomeworkId");

                    b.HasIndex("StudentIdUserID");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("University.AppLogic.Models.Homework", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AssignmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid?>("StudentIdUserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentID");

                    b.HasIndex("StudentIdUserID");

                    b.ToTable("Homeworks");
                });

            modelBuilder.Entity("University.AppLogic.Models.Require", b =>
                {
                    b.Property<Guid>("RequireID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClassroomID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid?>("StudentIdUserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RequireID");

                    b.HasIndex("ClassroomID");

                    b.HasIndex("StudentIdUserID");

                    b.ToTable("Requires");
                });

            modelBuilder.Entity("University.AppLogic.Models.User", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("University.AppLogic.Models.Assignments", b =>
                {
                    b.HasOne("University.AppLogic.Models.Classroom", "Classroom")
                        .WithMany()
                        .HasForeignKey("ClassroomID");
                });

            modelBuilder.Entity("University.AppLogic.Models.Grades", b =>
                {
                    b.HasOne("University.AppLogic.Models.Homework", "Homework")
                        .WithMany()
                        .HasForeignKey("HomeworkId");

                    b.HasOne("University.AppLogic.Models.User", "StudentId")
                        .WithMany()
                        .HasForeignKey("StudentIdUserID");
                });

            modelBuilder.Entity("University.AppLogic.Models.Homework", b =>
                {
                    b.HasOne("University.AppLogic.Models.Assignments", "Assignment")
                        .WithMany()
                        .HasForeignKey("AssignmentID");

                    b.HasOne("University.AppLogic.Models.User", "StudentId")
                        .WithMany()
                        .HasForeignKey("StudentIdUserID");
                });

            modelBuilder.Entity("University.AppLogic.Models.Require", b =>
                {
                    b.HasOne("University.AppLogic.Models.Classroom", "ClassroomId")
                        .WithMany()
                        .HasForeignKey("ClassroomID");

                    b.HasOne("University.AppLogic.Models.User", "StudentId")
                        .WithMany()
                        .HasForeignKey("StudentIdUserID");
                });
#pragma warning restore 612, 618
        }
    }
}

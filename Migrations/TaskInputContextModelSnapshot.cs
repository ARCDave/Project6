﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project6.Models;

namespace Project6.Migrations
{
    [DbContext(typeof(TaskInputContext))]
    partial class TaskInputContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Project6.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("Project6.Models.Quadrant", b =>
                {
                    b.Property<int>("QuadrantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("QuadrantName")
                        .HasColumnType("TEXT");

                    b.HasKey("QuadrantId");

                    b.ToTable("Quadrants");

                    b.HasData(
                        new
                        {
                            QuadrantId = 1,
                            QuadrantName = "1 - Import/Urgent"
                        },
                        new
                        {
                            QuadrantId = 2,
                            QuadrantName = "2 - Important/Not Urgent"
                        },
                        new
                        {
                            QuadrantId = 3,
                            QuadrantName = "3 - Not Important/Urgent"
                        },
                        new
                        {
                            QuadrantId = 4,
                            QuadrantName = "4 - Not Important/Not Urgent"
                        });
                });

            modelBuilder.Entity("Project6.Models.TaskInputModel", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuadrantId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Task")
                        .HasColumnType("TEXT");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("QuadrantId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            TaskId = 1,
                            CategoryId = 2,
                            Completed = false,
                            DueDate = new DateTime(2022, 2, 10, 14, 17, 30, 944, DateTimeKind.Local).AddTicks(3855),
                            QuadrantId = 1,
                            Task = "Finish this project"
                        },
                        new
                        {
                            TaskId = 2,
                            CategoryId = 3,
                            Completed = false,
                            DueDate = new DateTime(2022, 2, 10, 14, 17, 30, 947, DateTimeKind.Local).AddTicks(590),
                            QuadrantId = 2,
                            Task = "Study for Exam"
                        },
                        new
                        {
                            TaskId = 3,
                            CategoryId = 3,
                            Completed = false,
                            DueDate = new DateTime(2022, 2, 10, 14, 17, 30, 947, DateTimeKind.Local).AddTicks(668),
                            QuadrantId = 3,
                            Task = "Clean the Dishes"
                        },
                        new
                        {
                            TaskId = 4,
                            CategoryId = 1,
                            Completed = false,
                            DueDate = new DateTime(2022, 2, 10, 14, 17, 30, 947, DateTimeKind.Local).AddTicks(676),
                            QuadrantId = 4,
                            Task = "Sleep"
                        });
                });

            modelBuilder.Entity("Project6.Models.TaskInputModel", b =>
                {
                    b.HasOne("Project6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project6.Models.Quadrant", "Quadrant")
                        .WithMany()
                        .HasForeignKey("QuadrantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

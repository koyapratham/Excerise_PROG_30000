﻿// <auto-generated />
using System;
using API.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20221130175216_Change2")]
    partial class Change2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("API.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("numberOfCredits")
                        .HasColumnType("INTEGER");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("API.Models.Professor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("isFullTime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professors");
                });

            modelBuilder.Entity("CourseProfessor", b =>
                {
                    b.Property<Guid>("coursesId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("professorsId")
                        .HasColumnType("TEXT");

                    b.HasKey("coursesId", "professorsId");

                    b.HasIndex("professorsId");

                    b.ToTable("CourseProfessor");
                });

            modelBuilder.Entity("CourseProfessor", b =>
                {
                    b.HasOne("API.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("coursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.Professor", null)
                        .WithMany()
                        .HasForeignKey("professorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

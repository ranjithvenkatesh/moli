﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using moli.api.Models;

namespace moli.api.Migrations
{
    [DbContext(typeof(MoliContext))]
    [Migration("20190101172052_EmailUniqueOnUser")]
    partial class EmailUniqueOnUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("moli.api.Models.Answer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("QuestionId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("moli.api.Models.Audio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Path")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Audios");
                });

            modelBuilder.Entity("moli.api.Models.Image", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Path")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("moli.api.Models.Item", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AudioId");

                    b.Property<long?>("ImageId");

                    b.Property<long?>("LessonId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AudioId");

                    b.HasIndex("ImageId");

                    b.HasIndex("LessonId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("moli.api.Models.Lesson", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Numbers"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Days"
                        });
                });

            modelBuilder.Entity("moli.api.Models.Question", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AnswerId");

                    b.Property<long?>("TestId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("moli.api.Models.Test", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("moli.api.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "ranjithvenkatesh@hotmail.com",
                            Name = "Ranjith"
                        },
                        new
                        {
                            Id = 2L,
                            Email = "ranjith.venkatesh@mossandlichens.com",
                            Name = "Venkatesh"
                        });
                });

            modelBuilder.Entity("moli.api.Models.Answer", b =>
                {
                    b.HasOne("moli.api.Models.Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("moli.api.Models.Item", b =>
                {
                    b.HasOne("moli.api.Models.Audio", "Audio")
                        .WithMany()
                        .HasForeignKey("AudioId");

                    b.HasOne("moli.api.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.HasOne("moli.api.Models.Lesson")
                        .WithMany("Items")
                        .HasForeignKey("LessonId");
                });

            modelBuilder.Entity("moli.api.Models.Lesson", b =>
                {
                    b.HasOne("moli.api.Models.User")
                        .WithMany("Lessons")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("moli.api.Models.Question", b =>
                {
                    b.HasOne("moli.api.Models.Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("moli.api.Models.Test", b =>
                {
                    b.HasOne("moli.api.Models.User")
                        .WithMany("Tests")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}

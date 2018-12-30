﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using moli.api.Models;

namespace moli.api.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20181230065920_moli.api.Models.AddNameToUser")]
    partial class moliapiModelsAddNameToUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("moli.api.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1L, Email = "ranjithvenkatesh@hotmail.com" },
                        new { Id = 2L, Email = "ranjith.venkatesh@mossandlichens.com" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}

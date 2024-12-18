﻿// <auto-generated />
using BagAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BagAPI.Models.Migrations
{
    [DbContext(typeof(BagDBContext))]
    [Migration("20241218071413_MigrationForPendingChanges")]
    partial class MigrationForPendingChanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BagAPI.Models.Products", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("price")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("BagAPI.Models.Roles", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("BagAPI.Models.Users", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("gender")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("BagAPI.Models.Users", b =>
                {
                    b.HasOne("BagAPI.Models.Roles", "role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("role");
                });

            modelBuilder.Entity("BagAPI.Models.Roles", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
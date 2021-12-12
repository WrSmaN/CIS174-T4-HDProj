﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Team4_FinalProject.Models;

namespace Team4_FinalProject.Migrations
{
    [DbContext(typeof(TicketManagerDbContext))]
    [Migration("20211212191337_AddDateTimeFields")]
    partial class AddDateTimeFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Team4_FinalProject.Models.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(20000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 12, 12, 13, 13, 36, 348, DateTimeKind.Local).AddTicks(1969));

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("NoteId");

                    b.HasIndex("TicketId");

                    b.HasIndex("UserId1");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Team4_FinalProject.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("DateOpened")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 12, 12, 13, 13, 36, 343, DateTimeKind.Local).AddTicks(6861));

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            TicketId = 1,
                            Category = "Reported Issue 1",
                            DateOpened = new DateTime(2021, 12, 12, 13, 13, 36, 350, DateTimeKind.Local).AddTicks(5039),
                            Status = "Open",
                            UserId = 5
                        },
                        new
                        {
                            TicketId = 2,
                            Category = "Reported Issue ",
                            DateOpened = new DateTime(2021, 12, 12, 13, 13, 36, 350, DateTimeKind.Local).AddTicks(6713),
                            Status = "Open",
                            UserId = 5
                        });
                });

            modelBuilder.Entity("Team4_FinalProject.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<bool>("IsTechnician")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            FirstName = "Chasidy",
                            IsTechnician = true,
                            LastName = "Spurgeon",
                            Password = "password",
                            Username = "Chasidy"
                        },
                        new
                        {
                            UserId = 2,
                            FirstName = "Wade",
                            IsTechnician = true,
                            LastName = "Shafer",
                            Password = "password",
                            Username = "Wade"
                        },
                        new
                        {
                            UserId = 3,
                            FirstName = "John",
                            IsTechnician = true,
                            LastName = "Ryan",
                            Password = "password",
                            Username = "John"
                        },
                        new
                        {
                            UserId = 4,
                            FirstName = "Logan",
                            IsTechnician = true,
                            LastName = "Riedell",
                            Password = "password",
                            Username = "Logan"
                        },
                        new
                        {
                            UserId = 5,
                            FirstName = "Tom",
                            IsTechnician = false,
                            LastName = "Hanks",
                            Password = "passWord1",
                            Username = "GoodJoe12"
                        });
                });

            modelBuilder.Entity("Team4_FinalProject.Models.Note", b =>
                {
                    b.HasOne("Team4_FinalProject.Models.Ticket", "Ticket")
                        .WithMany("Notes")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Team4_FinalProject.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("Ticket");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Team4_FinalProject.Models.Ticket", b =>
                {
                    b.HasOne("Team4_FinalProject.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Team4_FinalProject.Models.Ticket", b =>
                {
                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}

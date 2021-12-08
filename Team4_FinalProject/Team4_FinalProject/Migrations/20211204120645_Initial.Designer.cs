﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Team4_FinalProject.Models;

namespace Team4_FinalProject.Migrations
{
    [DbContext(typeof(TicketManagerDbContext))]
    [Migration("20211204120645_Initial")]
    partial class Initial
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("NoteId");

                    b.HasIndex("TicketId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Team4_FinalProject.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Team4_FinalProject.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTechnician")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

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

                    b.Navigation("Ticket");
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

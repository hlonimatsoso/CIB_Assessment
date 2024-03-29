﻿// <auto-generated />
using CIB.PhoneBookData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CIB.PhoneBookData.Migrations
{
    [DbContext(typeof(PhoneBookDBContext))]
    [Migration("20191129131755_RequiredFields")]
    partial class RequiredFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CIB.Models.PhoneBook", b =>
                {
                    b.Property<int>("PhoneBookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneBookID");

                    b.ToTable("PhoneBooks");
                });

            modelBuilder.Entity("CIB.Models.PhoneBookEntry", b =>
                {
                    b.Property<int>("PhoneBookEntryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Numuber")
                        .HasColumnType("int");

                    b.Property<int>("PhoneBookID")
                        .HasColumnType("int");

                    b.HasKey("PhoneBookEntryID");

                    b.HasIndex("PhoneBookID");

                    b.ToTable("PhoneBookEntries");
                });

            modelBuilder.Entity("CIB.Models.PhoneBookEntry", b =>
                {
                    b.HasOne("CIB.Models.PhoneBook", "PhoneBook")
                        .WithMany("Entries")
                        .HasForeignKey("PhoneBookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

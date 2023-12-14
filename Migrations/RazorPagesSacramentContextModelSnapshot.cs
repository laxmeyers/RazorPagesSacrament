﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesSacrament.Data;

namespace RazorPagesSacrament.Migrations
{
    [DbContext(typeof(RazorPagesSacramentContext))]
    partial class RazorPagesSacramentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPagesSacrament.Models.Meeting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClosingHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosingPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConductingLeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("IntermediateHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speaker1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speaker2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speaker3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Meeting");
                });
#pragma warning restore 612, 618
        }
    }
}

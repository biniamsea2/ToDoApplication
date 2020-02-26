﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoWebApp.Data;

namespace ToDoWebApp.Migrations
{
    [DbContext(typeof(StorageDbContext))]
    [Migration("20200226084659_testing")]
    partial class testing
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDoWebApp.Models.ToDoList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<string>("DueDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ToDoPackage");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Completed = false,
                            DueDate = "2/20/2020",
                            Priority = 0,
                            Task = "Do Homework"
                        },
                        new
                        {
                            ID = 2,
                            Completed = false,
                            DueDate = "2/26/2020",
                            Priority = 2,
                            Task = "Get an oil change"
                        },
                        new
                        {
                            ID = 3,
                            Completed = true,
                            DueDate = "2/24/2020",
                            Priority = 1,
                            Task = "Clean room"
                        },
                        new
                        {
                            ID = 4,
                            Completed = true,
                            DueDate = "2/23/2020",
                            Priority = 2,
                            Task = "Go to the gym"
                        },
                        new
                        {
                            ID = 5,
                            Completed = false,
                            DueDate = "2/22/2020",
                            Priority = 0,
                            Task = "Wash dishes"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

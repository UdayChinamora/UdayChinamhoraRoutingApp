﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using UdayChinhamoraWebsite.Models;

using UdayChinhamoraWebsite.Models;

namespace UdayChinhamoraWebsite.Migrations
{
    [DbContext(typeof(TicketContext))]
    [Migration("20230405215448_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("UdayChinhamoraWebsite.Models.PointVal", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("PointVals");

                b.HasData(
                    new
                    {
                        Id = "1",
                        Name = "1"
                    },
                    new
                    {
                        Id = "2",
                        Name = "2"
                    },
                    new
                    {
                        Id = "3",
                        Name = "3"
                    },
                    new
                    {
                        Id = "5",
                        Name = "5"
                    },
                    new
                    {
                        Id = "8",
                        Name = "8"
                    },
                    new
                    {
                        Id = "13",
                        Name = "13"
                    },
                    new
                    {
                        Id = "21",
                        Name = "21"
                    },
                    new
                    {
                        Id = "34",
                        Name = "34"
                    },
                    new
                    {
                        Id = "55",
                        Name = "55"
                    },
                    new
                    {
                        Id = "89",
                        Name = "89"
                    });
            });

            modelBuilder.Entity("UdayChinhamoraWebsite.Models.SprintNum", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("SprintNums");

                b.HasData(
                    new
                    {
                        Id = "1",
                        Name = "1"
                    },
                    new
                    {
                        Id = "2",
                        Name = "2"
                    },
                    new
                    {
                        Id = "3",
                        Name = "3"
                    },
                    new
                    {
                        Id = "4",
                        Name = "4"
                    },
                    new
                    {
                        Id = "5",
                        Name = "5"
                    },
                    new
                    {
                        Id = "6",
                        Name = "6"
                    },
                    new
                    {
                        Id = "7",
                        Name = "7"
                    },
                    new
                    {
                        Id = "8",
                        Name = "8"
                    },
                    new
                    {
                        Id = "9",
                        Name = "9"
                    },
                    new
                    {
                        Id = "10",
                        Name = "10"
                    });
            });

            modelBuilder.Entity("UdayChinhamoraWebsite.Models.Status", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Statuses");

                b.HasData(
                    new
                    {
                        Id = "t",
                        Name = "To-Do"
                    },
                    new
                    {
                        Id = "i",
                        Name = "In Progress"
                    },
                    new
                    {
                        Id = "q",
                        Name = "Quality Assurance"
                    },
                    new
                    {
                        Id = "d",
                        Name = "Done"
                    });
            });

            modelBuilder.Entity("UdayChinhamoraWebsite.Models.Ticket", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .UseIdentityColumn();

                b.Property<string>("Description")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<string>("PointVal")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("SprintNum")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("StatusId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("StatusId");

                b.ToTable("Tickets");
            });

            modelBuilder.Entity("UdayChinhamoraWebsite.Models.Ticket", b =>
            {
                b.HasOne("UdayChinhamoraWebsite.Models.Status", "Status")
                    .WithMany()
                    .HasForeignKey("StatusId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Status");
            });
#pragma warning restore 612, 618
        }
    }
}
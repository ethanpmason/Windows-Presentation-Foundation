﻿// <auto-generated />
using CustomerConnectionsApp.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerConnectionsApp.EntityFramework.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerConnectionsApp.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("chrCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("strAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CustomerConnectionsApp.Models.Hardware", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("intJobId")
                        .HasColumnType("int");

                    b.Property<string>("strDefaultGateway")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strIPAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strSubnetMask")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("intJobId");

                    b.ToTable("Hardwares");
                });

            modelBuilder.Entity("CustomerConnectionsApp.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("intCustomerId")
                        .HasColumnType("int");

                    b.Property<string>("strAdditionalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strConnectionApplication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strConnectionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strJobNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("strUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("intCustomerId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("CustomerConnectionsApp.Models.Hardware", b =>
                {
                    b.HasOne("CustomerConnectionsApp.Models.Job", "Job")
                        .WithMany("Hardwares")
                        .HasForeignKey("intJobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("CustomerConnectionsApp.Models.Job", b =>
                {
                    b.HasOne("CustomerConnectionsApp.Models.Customer", "Customer")
                        .WithMany("Jobs")
                        .HasForeignKey("intCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CustomerConnectionsApp.Models.Customer", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("CustomerConnectionsApp.Models.Job", b =>
                {
                    b.Navigation("Hardwares");
                });
#pragma warning restore 612, 618
        }
    }
}

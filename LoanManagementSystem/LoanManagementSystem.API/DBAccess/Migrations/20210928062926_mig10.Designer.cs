// <auto-generated />
using System;
using LoanManagementSystem.API.DBAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoanManagementSystem.API.DBAccess.Migrations
{
    [DbContext(typeof(LoanManagementSystemDBContext))]
    [Migration("20210928062926_mig10")]
    partial class mig10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LoanManagementSystem.API.Entities.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("AadharNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal?>("CreditLimit")
                        .HasColumnType("numeric");

                    b.Property<string>("CustomerPassword")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("DOB")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime?>("LastUpdatedCreditDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PanNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("LoanManagementSystem.API.Entities.Employee", b =>
                {
                    b.Property<string>("EmpId")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("EmpPassword")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("EmpType")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("EmpId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("LoanManagementSystem.API.Entities.LoanDetails", b =>
                {
                    b.Property<string>("LoanAccNumber")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal?>("CreditLimit")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("CustomerAssetId")
                        .HasColumnType("numeric");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime?>("DispersalDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("EmiAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("EmiEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EmiStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmpId")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("InteresrRate")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime?>("LastUpdatedCreditDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("LoanAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("LoanApprovedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoanStatus")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("LoanType")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal?>("Tenure")
                        .HasColumnType("numeric");

                    b.HasKey("LoanAccNumber");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmpId");

                    b.ToTable("LoanDetails");
                });

            modelBuilder.Entity("LoanManagementSystem.API.Entities.LoanDetails", b =>
                {
                    b.HasOne("LoanManagementSystem.API.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoanManagementSystem.API.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmpId");

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}

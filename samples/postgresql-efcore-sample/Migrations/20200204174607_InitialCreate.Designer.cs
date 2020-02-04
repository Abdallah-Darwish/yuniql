﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using efsample.Models;

namespace efsample.Migrations
{
    [DbContext(typeof(yuniqldbContext))]
    [Migration("20200204174607_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("efsample.Models.Countries", b =>
                {
                    b.Property<string>("CountryId")
                        .HasColumnName("country_id")
                        .HasColumnType("character(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2);

                    b.Property<string>("CountryName")
                        .HasColumnName("country_name")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<int>("RegionId")
                        .HasColumnName("region_id")
                        .HasColumnType("integer");

                    b.HasKey("CountryId")
                        .HasName("countries_pkey");

                    b.HasIndex("RegionId");

                    b.ToTable("countries");
                });

            modelBuilder.Entity("efsample.Models.Departments", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("department_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnName("department_name")
                        .HasColumnType("character varying(30)")
                        .HasMaxLength(30);

                    b.Property<int?>("LocationId")
                        .HasColumnName("location_id")
                        .HasColumnType("integer");

                    b.HasKey("DepartmentId")
                        .HasName("departments_pkey");

                    b.HasIndex("LocationId");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("efsample.Models.Dependents", b =>
                {
                    b.Property<int>("DependentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("dependent_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnName("employee_id")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Relationship")
                        .IsRequired()
                        .HasColumnName("relationship")
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.HasKey("DependentId")
                        .HasName("dependents_pkey");

                    b.HasIndex("EmployeeId");

                    b.ToTable("dependents");
                });

            modelBuilder.Entity("efsample.Models.Employees", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("employee_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("DepartmentId")
                        .HasColumnName("department_id")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("HireDate")
                        .HasColumnName("hire_date")
                        .HasColumnType("date");

                    b.Property<int>("JobId")
                        .HasColumnName("job_id")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.Property<int?>("ManagerId")
                        .HasColumnName("manager_id")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<decimal>("Salary")
                        .HasColumnName("salary")
                        .HasColumnType("numeric(8,2)");

                    b.HasKey("EmployeeId")
                        .HasName("employees_pkey");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("JobId");

                    b.HasIndex("ManagerId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("efsample.Models.Jobs", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("job_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnName("job_title")
                        .HasColumnType("character varying(35)")
                        .HasMaxLength(35);

                    b.Property<decimal?>("MaxSalary")
                        .HasColumnName("max_salary")
                        .HasColumnType("numeric(8,2)");

                    b.Property<decimal?>("MinSalary")
                        .HasColumnName("min_salary")
                        .HasColumnType("numeric(8,2)");

                    b.HasKey("JobId")
                        .HasName("jobs_pkey");

                    b.ToTable("jobs");
                });

            modelBuilder.Entity("efsample.Models.Locations", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("location_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("city")
                        .HasColumnType("character varying(30)")
                        .HasMaxLength(30);

                    b.Property<string>("CountryId")
                        .IsRequired()
                        .HasColumnName("country_id")
                        .HasColumnType("character(2)")
                        .IsFixedLength(true)
                        .HasMaxLength(2);

                    b.Property<string>("PostalCode")
                        .HasColumnName("postal_code")
                        .HasColumnType("character varying(12)")
                        .HasMaxLength(12);

                    b.Property<string>("StateProvince")
                        .HasColumnName("state_province")
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.Property<string>("StreetAddress")
                        .HasColumnName("street_address")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.HasKey("LocationId")
                        .HasName("locations_pkey");

                    b.HasIndex("CountryId");

                    b.ToTable("locations");
                });

            modelBuilder.Entity("efsample.Models.Regions", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("region_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("RegionName")
                        .HasColumnName("region_name")
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.HasKey("RegionId")
                        .HasName("regions_pkey");

                    b.ToTable("regions");
                });

            modelBuilder.Entity("efsample.Models.TestClass", b =>
                {
                    b.Property<string>("TestColumn")
                        .HasColumnType("text");

                    b.Property<string>("TestId")
                        .HasColumnType("text");

                    b.ToTable("TestClass");
                });

            modelBuilder.Entity("efsample.Models.Yuniqldbversion", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<byte[]>("Artifact")
                        .HasColumnName("artifact")
                        .HasColumnType("bytea");

                    b.Property<DateTime>("Dateinsertedutc")
                        .HasColumnName("dateinsertedutc")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Lastupdatedutc")
                        .HasColumnName("lastupdatedutc")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Lastuserid")
                        .IsRequired()
                        .HasColumnName("lastuserid")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnName("version")
                        .HasColumnType("character varying(32)")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("Version")
                        .IsUnique()
                        .HasName("ix___yuniqldbversion");

                    b.ToTable("__yuniqldbversion");
                });

            modelBuilder.Entity("efsample.Models.Countries", b =>
                {
                    b.HasOne("efsample.Models.Regions", "Region")
                        .WithMany("Countries")
                        .HasForeignKey("RegionId")
                        .HasConstraintName("countries_region_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("efsample.Models.Departments", b =>
                {
                    b.HasOne("efsample.Models.Locations", "Location")
                        .WithMany("Departments")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("departments_location_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("efsample.Models.Dependents", b =>
                {
                    b.HasOne("efsample.Models.Employees", "Employee")
                        .WithMany("Dependents")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("dependents_employee_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("efsample.Models.Employees", b =>
                {
                    b.HasOne("efsample.Models.Departments", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("employees_department_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("efsample.Models.Jobs", "Job")
                        .WithMany("Employees")
                        .HasForeignKey("JobId")
                        .HasConstraintName("employees_job_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("efsample.Models.Employees", "Manager")
                        .WithMany("InverseManager")
                        .HasForeignKey("ManagerId")
                        .HasConstraintName("employees_manager_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("efsample.Models.Locations", b =>
                {
                    b.HasOne("efsample.Models.Countries", "Country")
                        .WithMany("Locations")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("locations_country_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

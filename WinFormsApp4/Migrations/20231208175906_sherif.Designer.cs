﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp4.data;

#nullable disable

namespace WinFormsApp4.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231208175906_sherif")]
    partial class sherif
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WinFormsApp4.data.EmployeeTable", b =>
                {
                    b.Property<string>("employee_n_id")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("email")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("name")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("password")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("phone_number")
                        .HasColumnType("char(11)");

                    b.Property<string>("photo_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_name")
                        .HasColumnType("varchar(10)");

                    b.HasKey("employee_n_id");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("WinFormsApp4.data.HistoryTable", b =>
                {
                    b.Property<int>("history_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("history_id"), 1L, 1);

                    b.Property<double>("cost")
                        .HasColumnType("float");

                    b.Property<string>("date")
                        .HasColumnType("char(10)");

                    b.Property<string>("employee_n_id")
                        .HasColumnType("char(15)");

                    b.Property<int>("paper_count")
                        .HasColumnType("int");

                    b.Property<string>("student_n_id")
                        .HasColumnType("char(15)");

                    b.Property<string>("time_in")
                        .HasColumnType("char(5)");

                    b.Property<string>("time_out")
                        .HasColumnType("char(5)");

                    b.HasKey("history_id");

                    b.ToTable("history");
                });

            modelBuilder.Entity("WinFormsApp4.data.InStudentsTable", b =>
                {
                    b.Property<string>("student_n_id")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("in_time")
                        .HasColumnType("char(5)");

                    b.Property<int>("paper_printed")
                        .HasColumnType("int");

                    b.HasKey("student_n_id");

                    b.ToTable("in_students");
                });

            modelBuilder.Entity("WinFormsApp4.data.StudentsTable", b =>
                {
                    b.Property<string>("student_n_id")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("faculty")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("varchar(20)");

                    b.HasKey("student_n_id");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}

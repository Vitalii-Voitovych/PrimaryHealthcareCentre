﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrimaryHealthcareCentre.Domain.EF;

#nullable disable

namespace PrimaryHealthcareCentre.Domain.Migrations
{
    [DbContext(typeof(PrimaryHealthCentreDbContext))]
    partial class PrimaryHealthCentreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<int>("CabinetNumber")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Examination", b =>
                {
                    b.Property<int>("ExaminationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExaminationId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReceptionId")
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExaminationId");

                    b.HasIndex("ReceptionId")
                        .IsUnique();

                    b.ToTable("Examinations");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.MedicalCard", b =>
                {
                    b.Property<int>("MedicalCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicalCardId"), 1L, 1);

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FillingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedicalHistory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("MedicalCardId");

                    b.HasIndex("PatientId")
                        .IsUnique();

                    b.ToTable("MedicalCards");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Preparation", b =>
                {
                    b.Property<int>("PreparationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PreparationId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityPills")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("PreparationId");

                    b.ToTable("Preparations");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("PreparationId")
                        .HasColumnType("int");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PreparationId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Reception", b =>
                {
                    b.Property<int>("ReceptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceptionId"), 1L, 1);

                    b.Property<DateTime>("DateOfReception")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("ReceptionId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("LogOfReception");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Examination", b =>
                {
                    b.HasOne("PrimaryHealthcareCentre.Domain.Model.Reception", "Reception")
                        .WithOne("Examination")
                        .HasForeignKey("PrimaryHealthcareCentre.Domain.Model.Examination", "ReceptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reception");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.MedicalCard", b =>
                {
                    b.HasOne("PrimaryHealthcareCentre.Domain.Model.Patient", "Patient")
                        .WithOne("MedicalCard")
                        .HasForeignKey("PrimaryHealthcareCentre.Domain.Model.MedicalCard", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Prescription", b =>
                {
                    b.HasOne("PrimaryHealthcareCentre.Domain.Model.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrimaryHealthcareCentre.Domain.Model.Preparation", "Preparation")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PreparationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Preparation");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Reception", b =>
                {
                    b.HasOne("PrimaryHealthcareCentre.Domain.Model.Doctor", "Doctor")
                        .WithMany("Receptions")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrimaryHealthcareCentre.Domain.Model.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Doctor", b =>
                {
                    b.Navigation("Receptions");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Patient", b =>
                {
                    b.Navigation("MedicalCard")
                        .IsRequired();

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Preparation", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("PrimaryHealthcareCentre.Domain.Model.Reception", b =>
                {
                    b.Navigation("Examination")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

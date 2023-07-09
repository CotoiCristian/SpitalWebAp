﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpitalFinal.Models;

#nullable disable

namespace SpitalFinal.Migrations
{
    [DbContext(typeof(SpitalContext))]
    [Migration("20230614062725_initial13")]
    partial class initial13
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SpitalFinal.Models.FisaMedic", b =>
                {
                    b.Property<int>("FisaMedicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FisaMedicId"));

                    b.Property<DateTime?>("DataExternare")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataInternare")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MedicId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacientId")
                        .HasColumnType("int");

                    b.Property<int>("RetetaMedicalaId")
                        .HasColumnType("int");

                    b.HasKey("FisaMedicId");

                    b.HasIndex("MedicId");

                    b.HasIndex("PacientId");

                    b.HasIndex("RetetaMedicalaId");

                    b.ToTable("FisaMedics");
                });

            modelBuilder.Entity("SpitalFinal.Models.Investigatie", b =>
                {
                    b.Property<int>("InvestigatieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvestigatieId"));

                    b.Property<int>("FisaMedicId")
                        .HasColumnType("int");

                    b.Property<string>("Rezultat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("datazilei")
                        .HasColumnType("datetime2");

                    b.HasKey("InvestigatieId");

                    b.HasIndex("FisaMedicId");

                    b.ToTable("Investigaties");
                });

            modelBuilder.Entity("SpitalFinal.Models.Medic", b =>
                {
                    b.Property<int>("MedicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicId"));

                    b.Property<DateTime>("DataNastere")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectieId")
                        .HasColumnType("int");

                    b.Property<string>("Specializare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Varsta")
                        .HasColumnType("int");

                    b.HasKey("MedicId");

                    b.HasIndex("SectieId");

                    b.ToTable("Medics");
                });

            modelBuilder.Entity("SpitalFinal.Models.Pacient", b =>
                {
                    b.Property<int>("PacientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacientId"));

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumePacient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Varsta")
                        .HasColumnType("int");

                    b.HasKey("PacientId");

                    b.ToTable("Pacients");
                });

            modelBuilder.Entity("SpitalFinal.Models.ProgramLucru", b =>
                {
                    b.Property<int>("ProgramLucruId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgramLucruId"));

                    b.Property<DateTime?>("DataLibera")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeZi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgramLucruId");

                    b.ToTable("ProgramLucrus");
                });

            modelBuilder.Entity("SpitalFinal.Models.Programare", b =>
                {
                    b.Property<int>("ProgramareId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgramareId"));

                    b.Property<DateTime?>("DataProgramari")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicId")
                        .HasColumnType("int");

                    b.Property<int>("ProgramLucruId")
                        .HasColumnType("int");

                    b.Property<int>("Varsta")
                        .HasColumnType("int");

                    b.Property<string>("nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sex")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgramareId");

                    b.HasIndex("MedicId");

                    b.HasIndex("ProgramLucruId");

                    b.ToTable("Programares");
                });

            modelBuilder.Entity("SpitalFinal.Models.RetetaMedicala", b =>
                {
                    b.Property<int>("RetetaMedicalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RetetaMedicalaId"));

                    b.Property<DateTime?>("DataExpirare")
                        .HasColumnType("datetime2");

                    b.Property<string>("Denumire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prospect")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RetetaMedicalaId");

                    b.ToTable("RetetaMedicalas");
                });

            modelBuilder.Entity("SpitalFinal.Models.Sectie", b =>
                {
                    b.Property<int>("SectieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SectieId"));

                    b.Property<int>("Etaj")
                        .HasColumnType("int");

                    b.Property<string>("NumeSectie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SectieId");

                    b.ToTable("Secties");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SpitalFinal.Models.FisaMedic", b =>
                {
                    b.HasOne("SpitalFinal.Models.Medic", "Medic")
                        .WithMany()
                        .HasForeignKey("MedicId");

                    b.HasOne("SpitalFinal.Models.Pacient", "Pacient")
                        .WithMany("FisaMedics")
                        .HasForeignKey("PacientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpitalFinal.Models.RetetaMedicala", "RetetaMedicala")
                        .WithMany("FisaMedics")
                        .HasForeignKey("RetetaMedicalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medic");

                    b.Navigation("Pacient");

                    b.Navigation("RetetaMedicala");
                });

            modelBuilder.Entity("SpitalFinal.Models.Investigatie", b =>
                {
                    b.HasOne("SpitalFinal.Models.FisaMedic", "FisaMedic")
                        .WithMany()
                        .HasForeignKey("FisaMedicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FisaMedic");
                });

            modelBuilder.Entity("SpitalFinal.Models.Medic", b =>
                {
                    b.HasOne("SpitalFinal.Models.Sectie", "Sectie")
                        .WithMany("Medics")
                        .HasForeignKey("SectieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sectie");
                });

            modelBuilder.Entity("SpitalFinal.Models.Programare", b =>
                {
                    b.HasOne("SpitalFinal.Models.Medic", "Medic")
                        .WithMany()
                        .HasForeignKey("MedicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpitalFinal.Models.ProgramLucru", "ProgramLucru")
                        .WithMany("Programares")
                        .HasForeignKey("ProgramLucruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medic");

                    b.Navigation("ProgramLucru");
                });

            modelBuilder.Entity("SpitalFinal.Models.Pacient", b =>
                {
                    b.Navigation("FisaMedics");
                });

            modelBuilder.Entity("SpitalFinal.Models.ProgramLucru", b =>
                {
                    b.Navigation("Programares");
                });

            modelBuilder.Entity("SpitalFinal.Models.RetetaMedicala", b =>
                {
                    b.Navigation("FisaMedics");
                });

            modelBuilder.Entity("SpitalFinal.Models.Sectie", b =>
                {
                    b.Navigation("Medics");
                });
#pragma warning restore 612, 618
        }
    }
}

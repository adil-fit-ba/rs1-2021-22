﻿// <auto-generated />
using System;
using FIT_Api_Examples.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FIT_Api_Examples.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211212230722_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FIT_Api_Examples.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("ipAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vrijednost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("isDekan")
                        .HasColumnType("bit");

                    b.Property<bool>("isProdekan")
                        .HasColumnType("bit");

                    b.Property<bool>("isStudentskaSluzba")
                        .HasColumnType("bit");

                    b.Property<string>("korisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slika_korisnika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Drzava", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Opstina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("drzava_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("drzava_id");

                    b.ToTable("Opstina");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.Ispit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DatumIspita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PredmetID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PredmetID");

                    b.ToTable("Ispit");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.Predmet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<float>("ECTS")
                        .HasColumnType("real");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifra")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.PrijavaIspita", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DatumPrijave")
                        .HasColumnType("datetime2");

                    b.Property<int>("IspitID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PrijavaIspita");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Student", b =>
                {
                    b.HasBaseType("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("broj_indeksa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("datum_rodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("opstina_rodjenja_id")
                        .HasColumnType("int");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("opstina_rodjenja_id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.Nastavnik", b =>
                {
                    b.HasBaseType("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Nastavnik");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", "korisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnickiNalog");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Opstina", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul2.Models.Drzava", "drzava")
                        .WithMany()
                        .HasForeignKey("drzava_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("drzava");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.Ispit", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul3.Models.Predmet", "predmet")
                        .WithMany()
                        .HasForeignKey("PredmetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("predmet");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Student", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("FIT_Api_Examples.Modul2.Models.Student", "id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("FIT_Api_Examples.Modul2.Models.Opstina", "opstina_rodjenja")
                        .WithMany()
                        .HasForeignKey("opstina_rodjenja_id");

                    b.Navigation("opstina_rodjenja");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.Nastavnik", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("FIT_Api_Examples.Modul3.Models.Nastavnik", "id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

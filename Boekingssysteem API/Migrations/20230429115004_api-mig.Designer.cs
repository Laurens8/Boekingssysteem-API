﻿// <auto-generated />
using System;
using Boekingssysteem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Boekingssysteem_API.Migrations
{
    [DbContext(typeof(BoekingssysteemContext))]
    [Migration("20230429115004_api-mig")]
    partial class apimig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Boekingssysteem.Models.Afwezigheid", b =>
                {
                    b.Property<int>("AfwezigheidID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AfwezigheidID"));

                    b.Property<DateTime>("Begindatum")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EindDatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Personeelnummer")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("PersoonPersoneelnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("AfwezigheidID");

                    b.HasIndex("PersoonPersoneelnummer");

                    b.ToTable("Afwezigheden");
                });

            modelBuilder.Entity("Boekingssysteem.Models.Functie", b =>
                {
                    b.Property<int>("FunctieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FunctieID"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FunctieID");

                    b.ToTable("Functies");
                });

            modelBuilder.Entity("Boekingssysteem.Models.Persoon", b =>
                {
                    b.Property<string>("Personeelnummer")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<bool?>("Aanwezig")
                        .HasColumnType("bit");

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Personeelnummer");

                    b.ToTable("Personen");
                });

            modelBuilder.Entity("Boekingssysteem.Models.PersoonFunctie", b =>
                {
                    b.Property<int>("PersoonFunctieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersoonFunctieID"));

                    b.Property<int>("FunctieID")
                        .HasColumnType("int");

                    b.Property<string>("Personeelnummer")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("PersoonPersoneelnummer")
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("PersoonFunctieID");

                    b.HasIndex("FunctieID");

                    b.HasIndex("PersoonPersoneelnummer");

                    b.ToTable("PersoonFuncties");
                });

            modelBuilder.Entity("Boekingssysteem.Models.PersoonRichting", b =>
                {
                    b.Property<int>("PersoonRichtingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersoonRichtingID"));

                    b.Property<string>("Personeelnummer")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("PersoonPersoneelnummer")
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("RichtingID")
                        .HasColumnType("int");

                    b.HasKey("PersoonRichtingID");

                    b.HasIndex("PersoonPersoneelnummer");

                    b.HasIndex("RichtingID");

                    b.ToTable("PersoonRichtingen");
                });

            modelBuilder.Entity("Boekingssysteem.Models.Richting", b =>
                {
                    b.Property<int>("RichtingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RichtingID"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RichtingID");

                    b.ToTable("Richtingen");
                });

            modelBuilder.Entity("Boekingssysteem.Models.Afwezigheid", b =>
                {
                    b.HasOne("Boekingssysteem.Models.Persoon", "Persoon")
                        .WithMany("Afwezigheden")
                        .HasForeignKey("PersoonPersoneelnummer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persoon");
                });

            modelBuilder.Entity("Boekingssysteem.Models.PersoonFunctie", b =>
                {
                    b.HasOne("Boekingssysteem.Models.Functie", "Functie")
                        .WithMany("PersoonFuncties")
                        .HasForeignKey("FunctieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Boekingssysteem.Models.Persoon", "Persoon")
                        .WithMany("PersoonFuncties")
                        .HasForeignKey("PersoonPersoneelnummer");

                    b.Navigation("Functie");

                    b.Navigation("Persoon");
                });

            modelBuilder.Entity("Boekingssysteem.Models.PersoonRichting", b =>
                {
                    b.HasOne("Boekingssysteem.Models.Persoon", "Persoon")
                        .WithMany("PersoonRichtingen")
                        .HasForeignKey("PersoonPersoneelnummer");

                    b.HasOne("Boekingssysteem.Models.Richting", "Richting")
                        .WithMany("PersoonRichtingen")
                        .HasForeignKey("RichtingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persoon");

                    b.Navigation("Richting");
                });

            modelBuilder.Entity("Boekingssysteem.Models.Functie", b =>
                {
                    b.Navigation("PersoonFuncties");
                });

            modelBuilder.Entity("Boekingssysteem.Models.Persoon", b =>
                {
                    b.Navigation("Afwezigheden");

                    b.Navigation("PersoonFuncties");

                    b.Navigation("PersoonRichtingen");
                });

            modelBuilder.Entity("Boekingssysteem.Models.Richting", b =>
                {
                    b.Navigation("PersoonRichtingen");
                });
#pragma warning restore 612, 618
        }
    }
}

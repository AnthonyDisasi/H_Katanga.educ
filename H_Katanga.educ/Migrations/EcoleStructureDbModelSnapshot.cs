﻿// <auto-generated />
using System;
using H_Katanga.educ.Areas.EcoleStruct.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace H_Katanga.educ.Migrations
{
    [DbContext(typeof(EcoleStructureDb))]
    partial class EcoleStructureDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Categorie", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Classe", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EcoleID");

                    b.Property<string>("Niveau")
                        .IsRequired();

                    b.Property<string>("Option");

                    b.Property<string>("Section")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("EcoleID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Cours", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categorie");

                    b.Property<string>("ClasseID");

                    b.Property<string>("Intituler");

                    b.HasKey("ID");

                    b.HasIndex("ClasseID");

                    b.ToTable("Cours");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Directeur", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateNaissance");

                    b.Property<string>("Email");

                    b.Property<int?>("Genre");

                    b.Property<string>("Matricule")
                        .IsRequired();

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.Property<string>("Postnom")
                        .IsRequired();

                    b.Property<string>("Prenom")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Directeurs");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Ecole", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DirecteurID");

                    b.Property<string>("EcoleLatitude");

                    b.Property<string>("EcoleLongitude");

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.Property<string>("SousDivision")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("DirecteurID")
                        .IsUnique()
                        .HasFilter("[DirecteurID] IS NOT NULL");

                    b.ToTable("Ecoles");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Eleve", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateNaissance");

                    b.Property<int?>("Genre");

                    b.Property<string>("Matricule")
                        .IsRequired();

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.Property<string>("Postnom")
                        .IsRequired();

                    b.Property<string>("Prenom")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Eleves");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Inscription", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnneeScolaire");

                    b.Property<string>("ClasseID");

                    b.Property<DateTime>("DateInscription");

                    b.Property<string>("EleveId");

                    b.HasKey("ID");

                    b.HasIndex("ClasseID");

                    b.HasIndex("EleveId");

                    b.ToTable("Inscriptions");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Option", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Professeur", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateNaissance");

                    b.Property<string>("EcoleID");

                    b.Property<string>("Email");

                    b.Property<int?>("Genre");

                    b.Property<string>("Matricule")
                        .IsRequired();

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.Property<string>("Postnom")
                        .IsRequired();

                    b.Property<string>("Prenom")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("EcoleID");

                    b.ToTable("Professeurs");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Section", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.SousDivision", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("SousDivisions");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Classe", b =>
                {
                    b.HasOne("H_Katanga.educ.Areas.EcoleStruct.Models.Ecole", "Ecole")
                        .WithMany("Classes")
                        .HasForeignKey("EcoleID");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Cours", b =>
                {
                    b.HasOne("H_Katanga.educ.Areas.EcoleStruct.Models.Classe", "Classe")
                        .WithMany("Cours")
                        .HasForeignKey("ClasseID");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Ecole", b =>
                {
                    b.HasOne("H_Katanga.educ.Areas.EcoleStruct.Models.Directeur", "Directeur")
                        .WithOne("Ecole")
                        .HasForeignKey("H_Katanga.educ.Areas.EcoleStruct.Models.Ecole", "DirecteurID");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Inscription", b =>
                {
                    b.HasOne("H_Katanga.educ.Areas.EcoleStruct.Models.Classe", "Classe")
                        .WithMany("Inscriptions")
                        .HasForeignKey("ClasseID");

                    b.HasOne("H_Katanga.educ.Areas.EcoleStruct.Models.Eleve", "Eleve")
                        .WithMany("Inscriptions")
                        .HasForeignKey("EleveId");
                });

            modelBuilder.Entity("H_Katanga.educ.Areas.EcoleStruct.Models.Professeur", b =>
                {
                    b.HasOne("H_Katanga.educ.Areas.EcoleStruct.Models.Ecole", "Ecole")
                        .WithMany("Professeurs")
                        .HasForeignKey("EcoleID");
                });
#pragma warning restore 612, 618
        }
    }
}

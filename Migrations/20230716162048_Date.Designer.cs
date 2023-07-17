﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IntroAEFCore.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20230716162048_Date")]
    partial class Date
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.Property<int>("GenerosId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.HasKey("GenerosId", "PeliculasId");

                    b.HasIndex("PeliculasId");

                    b.ToTable("GeneroPelicula");
                });

            modelBuilder.Entity("IntroAEFCore.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimineto")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Fortuna")
                        .HasMaxLength(500)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Actores");
                });

            modelBuilder.Entity("IntroAEFCore.Entities.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contenido")
                        .HasColumnType("longtext");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<bool>("Recomendar")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("PeliculaId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("IntroAEFCore.Entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("IntroAEFCore.Entities.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("EnCines")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("date");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("IntroAEFCore.Entities.PeliculaActor", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("PeliculasActores");
                });

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.HasOne("IntroAEFCore.Entities.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntroAEFCore.Entities.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IntroAEFCore.Entities.Comentario", b =>
                {
                    b.HasOne("IntroAEFCore.Entities.Pelicula", "Pelicula")
                        .WithMany("Comentarios")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("IntroAEFCore.Entities.PeliculaActor", b =>
                {
                    b.HasOne("IntroAEFCore.Entities.Actor", "Actor")
                        .WithMany("PeliculasActores")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntroAEFCore.Entities.Pelicula", "Pelicula")
                        .WithMany("PeliculasActores")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("IntroAEFCore.Entities.Actor", b =>
                {
                    b.Navigation("PeliculasActores");
                });

            modelBuilder.Entity("IntroAEFCore.Entities.Pelicula", b =>
                {
                    b.Navigation("Comentarios");

                    b.Navigation("PeliculasActores");
                });
#pragma warning restore 612, 618
        }
    }
}
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
    [Migration("20230719033908_Initial")]
    partial class Initial
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

                    b.HasData(
                        new
                        {
                            Id = 8,
                            FechaNacimineto = new DateTime(1998, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortuna = 15000m,
                            Nombre = "Samuel L. Jackson"
                        },
                        new
                        {
                            Id = 9,
                            FechaNacimineto = new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fortuna = 18000m,
                            Nombre = "Robert Downey Jr."
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Contenido = "Muy buena pelicuala",
                            PeliculaId = 3,
                            Recomendar = true
                        },
                        new
                        {
                            Id = 3,
                            Contenido = "Las peleas son interesantes",
                            PeliculaId = 4,
                            Recomendar = true
                        },
                        new
                        {
                            Id = 4,
                            Contenido = "Muy aburrida y lenta",
                            PeliculaId = 5,
                            Recomendar = false
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 3,
                            EnCines = false,
                            FechaEstreno = new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Avengers Endgame"
                        },
                        new
                        {
                            Id = 4,
                            EnCines = false,
                            FechaEstreno = new DateTime(2013, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Twiligth"
                        },
                        new
                        {
                            Id = 5,
                            EnCines = false,
                            FechaEstreno = new DateTime(2018, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Toy Story 3"
                        });
                });

            modelBuilder.Entity("IntroAEFCore.Entities.PeliculaActor", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<string>("Personaje")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ActorId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("PeliculasActores");

                    b.HasData(
                        new
                        {
                            ActorId = 9,
                            PeliculaId = 3,
                            Personaje = "Nick Fury"
                        },
                        new
                        {
                            ActorId = 8,
                            PeliculaId = 4,
                            Personaje = "Jake Lannister"
                        });
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

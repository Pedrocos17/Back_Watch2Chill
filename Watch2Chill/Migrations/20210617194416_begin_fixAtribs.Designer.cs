﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Watch2Chill.Data;

namespace Watch2Chill.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210617194416_begin_fixAtribs")]
    partial class begin_fixAtribs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Watch2Chill.Models.Episodios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_serieFK")
                        .HasColumnType("int");

                    b.Property<int?>("Id_serieIdSerie")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_serieIdSerie");

                    b.ToTable("Episodios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Id_serieFK = 0,
                            Nome = "The Godfather"
                        },
                        new
                        {
                            Id = 2,
                            Id_serieFK = 0,
                            Nome = "The dark Knight"
                        },
                        new
                        {
                            Id = 3,
                            Id_serieFK = 0,
                            Nome = "The Lord of the Rings"
                        },
                        new
                        {
                            Id = 4,
                            Id_serieFK = 0,
                            Nome = "Star Wars: Episode I"
                        },
                        new
                        {
                            Id = 5,
                            Id_serieFK = 0,
                            Nome = "Harry Potter"
                        },
                        new
                        {
                            Id = 6,
                            Id_serieFK = 1,
                            Nome = "Pilot"
                        },
                        new
                        {
                            Id = 7,
                            Id_serieFK = 1,
                            Nome = "Winter Is Coming"
                        },
                        new
                        {
                            Id = 8,
                            Id_serieFK = 1,
                            Nome = "Pilot"
                        },
                        new
                        {
                            Id = 9,
                            Id_serieFK = 1,
                            Nome = "The Matter Transfer Array"
                        },
                        new
                        {
                            Id = 10,
                            Id_serieFK = 1,
                            Nome = "Chapter One"
                        });
                });

            modelBuilder.Entity("Watch2Chill.Models.Temporadas", b =>
                {
                    b.Property<int>("IdSerie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataFim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdVideo")
                        .HasColumnType("int");

                    b.Property<int>("IdVideosFK")
                        .HasColumnType("int");

                    b.Property<int>("NumEps")
                        .HasColumnType("int");

                    b.Property<int>("NumTemps")
                        .HasColumnType("int");

                    b.HasKey("IdSerie");

                    b.HasIndex("IdVideo");

                    b.ToTable("Temporadas");

                    b.HasData(
                        new
                        {
                            IdSerie = 1,
                            IdVideosFK = 1,
                            NumEps = 1,
                            NumTemps = 0
                        },
                        new
                        {
                            IdSerie = 2,
                            IdVideosFK = 2,
                            NumEps = 1,
                            NumTemps = 0
                        },
                        new
                        {
                            IdSerie = 3,
                            IdVideosFK = 3,
                            NumEps = 1,
                            NumTemps = 0
                        },
                        new
                        {
                            IdSerie = 4,
                            IdVideosFK = 4,
                            NumEps = 1,
                            NumTemps = 0
                        },
                        new
                        {
                            IdSerie = 5,
                            IdVideosFK = 5,
                            NumEps = 1,
                            NumTemps = 0
                        },
                        new
                        {
                            IdSerie = 6,
                            DataFim = "2015",
                            IdVideosFK = 6,
                            NumEps = 62,
                            NumTemps = 5
                        },
                        new
                        {
                            IdSerie = 7,
                            DataFim = "2019",
                            IdVideosFK = 7,
                            NumEps = 73,
                            NumTemps = 3
                        },
                        new
                        {
                            IdSerie = 8,
                            DataFim = "Ainda a decorrer",
                            IdVideosFK = 8,
                            NumEps = 41,
                            NumTemps = 4
                        },
                        new
                        {
                            IdSerie = 9,
                            DataFim = "Ainda a decorrer",
                            IdVideosFK = 9,
                            NumEps = 16,
                            NumTemps = 2
                        },
                        new
                        {
                            IdSerie = 10,
                            DataFim = "Ainda a decorrer",
                            IdVideosFK = 10,
                            NumEps = 30,
                            NumTemps = 3
                        });
                });

            modelBuilder.Entity("Watch2Chill.Models.Utilizadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodPostal")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilizadores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodPostal = "2313-231",
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "a@a.a",
                            Morada = "Rua do Lago",
                            Nome = "Fernando Fernao",
                            Sexo = "M"
                        },
                        new
                        {
                            Id = 2,
                            CodPostal = "3100-121",
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "b@b.b",
                            Morada = "Rua da Estrela",
                            Nome = "Rodrigo Rodrigues",
                            Sexo = "M"
                        },
                        new
                        {
                            Id = 3,
                            CodPostal = "3152-344",
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "c@c.c",
                            Morada = "Rua da Lua",
                            Nome = "Gonçalo Gonçalves",
                            Sexo = "M"
                        },
                        new
                        {
                            Id = 4,
                            CodPostal = "1222-783",
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "d@d.d",
                            Morada = "Rua do Sol",
                            Nome = "Maria Silva",
                            Sexo = "F"
                        },
                        new
                        {
                            Id = 5,
                            CodPostal = "1284-231",
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "e@e.e",
                            Morada = "Rua da Ribeira",
                            Nome = "Bernardo Alentejo",
                            Sexo = "M"
                        });
                });

            modelBuilder.Entity("Watch2Chill.Models.UtilizadoresVideos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUtilizadorFK")
                        .HasColumnType("int");

                    b.Property<int>("IdVideoFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUtilizadorFK");

                    b.HasIndex("IdVideoFK");

                    b.ToTable("UtilizadoresVideos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdUtilizadorFK = 2,
                            IdVideoFK = 1
                        },
                        new
                        {
                            Id = 2,
                            IdUtilizadorFK = 3,
                            IdVideoFK = 2
                        },
                        new
                        {
                            Id = 3,
                            IdUtilizadorFK = 4,
                            IdVideoFK = 3
                        });
                });

            modelBuilder.Entity("Watch2Chill.Models.Videos", b =>
                {
                    b.Property<int>("IdVideo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Elenco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idioma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NTemporadas")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Realizador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVideo");

                    b.ToTable("Videos");

                    b.HasData(
                        new
                        {
                            IdVideo = 1,
                            Ano = 1972,
                            Elenco = "Al Pacino, Marlon Brando, James Caan, Richard S. Castellano",
                            Genero = "Crime, Drama",
                            Idioma = "Inglês",
                            NTemporadas = 0,
                            Nome = "The Godfather",
                            Realizador = "Francis Ford Coppola"
                        },
                        new
                        {
                            IdVideo = 2,
                            Ano = 2008,
                            Elenco = "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine",
                            Genero = "Crime, Drama, Ação",
                            Idioma = "Inglês",
                            NTemporadas = 0,
                            Nome = "The dark Knight",
                            Realizador = "Christopher Nolan"
                        },
                        new
                        {
                            IdVideo = 3,
                            Ano = 2001,
                            Elenco = "Alan Howard, Noel Appleby, Sean Astin, Sala Baker",
                            Genero = "Aventura, Fantasia, Drama",
                            Idioma = "Inglês",
                            NTemporadas = 0,
                            Nome = "The Lord of the Rings",
                            Realizador = "Peter Jackson"
                        },
                        new
                        {
                            IdVideo = 4,
                            Ano = 1977,
                            Elenco = "Mark Hamill, Harrison Ford, Carrie Fisher, Peter Cushing",
                            Genero = "Aventura, Ação, Fantasia",
                            Idioma = "Inglês",
                            NTemporadas = 0,
                            Nome = "Star Wars: Episode I",
                            Realizador = "George Lucas"
                        },
                        new
                        {
                            IdVideo = 5,
                            Ano = 2001,
                            Elenco = "Daniel Radcliffe, Rupert Grint, Richard Harris",
                            Genero = "Fantasia, Aventura, Família",
                            Idioma = "Inglês",
                            NTemporadas = 0,
                            Nome = "Harry Potter",
                            Realizador = "Chris Columbus"
                        },
                        new
                        {
                            IdVideo = 6,
                            Ano = 2008,
                            Elenco = "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris",
                            Genero = "Drama, Crime, Thriller",
                            Idioma = "Inglês",
                            NTemporadas = 5,
                            Nome = "Breaking Bad",
                            Realizador = "Vince Gilligan"
                        },
                        new
                        {
                            IdVideo = 7,
                            Ano = 2011,
                            Elenco = " Emilia Clarke, Peter Dinklage, Lena Headey, Peter Dinklage, Kit Harington",
                            Genero = "Aventura, Drama, Fantasia",
                            Idioma = "Inglês",
                            NTemporadas = 8,
                            Nome = "Game of Thrones",
                            Realizador = "D.B. Weiss, David Benioff"
                        },
                        new
                        {
                            IdVideo = 8,
                            Ano = 2013,
                            Elenco = "Justin Roiland, Chris Parnell, Spencer Grammer, Sarah Chalke",
                            Genero = "Animação, Aventura, Comédia",
                            Idioma = "Inglês",
                            NTemporadas = 41,
                            Nome = "Rick and Morty",
                            Realizador = "Dan Harmon, Justin Roiland"
                        },
                        new
                        {
                            IdVideo = 9,
                            Ano = 2020,
                            Elenco = "Justin Roiland, Sean Giambrone, Thomas Middleditch",
                            Genero = "Animação, Faroeste, Ficção Científica",
                            Idioma = "Inglês",
                            NTemporadas = 2,
                            Nome = "Solar Opposites",
                            Realizador = "Justin Roiland, Mike McMahan"
                        },
                        new
                        {
                            IdVideo = 10,
                            Ano = 2018,
                            Elenco = "Olan Rogers, Fred Armisen, David Tennant",
                            Genero = "Animação, Aventura, Comédia",
                            Idioma = "Inglês",
                            NTemporadas = 3,
                            Nome = "Final Space",
                            Realizador = "Olan Rogers"
                        });
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

            modelBuilder.Entity("Watch2Chill.Models.Episodios", b =>
                {
                    b.HasOne("Watch2Chill.Models.Temporadas", "Id_serie")
                        .WithMany("ListaDeEpisodios")
                        .HasForeignKey("Id_serieIdSerie");

                    b.Navigation("Id_serie");
                });

            modelBuilder.Entity("Watch2Chill.Models.Temporadas", b =>
                {
                    b.HasOne("Watch2Chill.Models.Videos", "Id")
                        .WithMany("ListaDeTemporadas")
                        .HasForeignKey("IdVideo");

                    b.Navigation("Id");
                });

            modelBuilder.Entity("Watch2Chill.Models.UtilizadoresVideos", b =>
                {
                    b.HasOne("Watch2Chill.Models.Utilizadores", "IdUtilizador")
                        .WithMany("ListaDeVideos")
                        .HasForeignKey("IdUtilizadorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watch2Chill.Models.Videos", "IdVideo")
                        .WithMany("ListaDeUtilizadores")
                        .HasForeignKey("IdVideoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdUtilizador");

                    b.Navigation("IdVideo");
                });

            modelBuilder.Entity("Watch2Chill.Models.Temporadas", b =>
                {
                    b.Navigation("ListaDeEpisodios");
                });

            modelBuilder.Entity("Watch2Chill.Models.Utilizadores", b =>
                {
                    b.Navigation("ListaDeVideos");
                });

            modelBuilder.Entity("Watch2Chill.Models.Videos", b =>
                {
                    b.Navigation("ListaDeTemporadas");

                    b.Navigation("ListaDeUtilizadores");
                });
#pragma warning restore 612, 618
        }
    }
}

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
    [Migration("20210713151753_CorrecaoNomesUtilizadorVideo")]
    partial class CorrecaoNomesUtilizadorVideo
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

                    b.HasData(
                        new
                        {
                            Id = "a",
                            ConcurrencyStamp = "81576801-cfce-43e9-a958-a28b22e01611",
                            Name = "Admninistrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "u",
                            ConcurrencyStamp = "7078d42d-1f95-411c-961d-1098a39d120e",
                            Name = "Utilizador",
                            NormalizedName = "UTILIZADOR"
                        });
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

            modelBuilder.Entity("Watch2Chill.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataRegisto")
                        .HasColumnType("datetime2");

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
                            Nome = "Pilot",
                            Video = "Pilot.mp4"
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

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdVideosFK")
                        .HasColumnType("int");

                    b.Property<int>("NumEps")
                        .HasColumnType("int");

                    b.Property<int>("NumTemps")
                        .HasColumnType("int");

                    b.HasKey("IdSerie");

                    b.HasIndex("IdVideosFK");

                    b.ToTable("Temporadas");

                    b.HasData(
                        new
                        {
                            IdSerie = 1,
                            Data = "",
                            IdVideosFK = 1,
                            NumEps = 1,
                            NumTemps = 0
                        },
                        new
                        {
                            IdSerie = 2,
                            Data = "",
                            IdVideosFK = 2,
                            NumEps = 1,
                            NumTemps = 0
                        },
                        new
                        {
                            IdSerie = 3,
                            Data = "",
                            IdVideosFK = 3,
                            NumEps = 1,
                            NumTemps = 0
                        },
                        new
                        {
                            IdSerie = 4,
                            Data = "",
                            IdVideosFK = 4,
                            NumEps = 1,
                            NumTemps = 0
                        },
                        new
                        {
                            IdSerie = 5,
                            Data = "",
                            IdVideosFK = 5,
                            NumEps = 1,
                            NumTemps = 0
                        },
                        new
                        {
                            IdSerie = 6,
                            Data = "2015",
                            IdVideosFK = 6,
                            NumEps = 62,
                            NumTemps = 5
                        },
                        new
                        {
                            IdSerie = 7,
                            Data = "2019",
                            IdVideosFK = 7,
                            NumEps = 73,
                            NumTemps = 3
                        },
                        new
                        {
                            IdSerie = 8,
                            Data = "Ainda a decorrer",
                            IdVideosFK = 8,
                            NumEps = 41,
                            NumTemps = 4
                        },
                        new
                        {
                            IdSerie = 9,
                            Data = "Ainda a decorrer",
                            IdVideosFK = 9,
                            NumEps = 16,
                            NumTemps = 2
                        },
                        new
                        {
                            IdSerie = 10,
                            Data = "Ainda a decorrer",
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilizadores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin1@admin1.com",
                            Morada = "Rua da Lua",
                            Nome = "Administrador",
                            Sexo = "M",
                            UserId = "3d934ae8-b06a-40af-9037-ab0c50f1ead0",
                            UserName = "3d934ae8-b06a-40af-9037-ab0c50f1ead0"
                        },
                        new
                        {
                            Id = 2,
                            DataNascimento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "utilizador@utilizador.com",
                            Morada = "Rua da Lua",
                            Nome = "Utilizador",
                            Sexo = "M",
                            UserId = "9e2e24bf-9156-4caa-9f03-af7e1602d545",
                            UserName = "9e2e24bf-9156-4caa-9f03-af7e1602d545"
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
                            IdUtilizadorFK = 1,
                            IdVideoFK = 1
                        },
                        new
                        {
                            Id = 2,
                            IdUtilizadorFK = 2,
                            IdVideoFK = 2
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idioma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NTemporadas")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Realizador")
                        .IsRequired()
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
                            Foto = "TheGodfather.jpg",
                            Genero = "Crime, Drama",
                            Idioma = "Inglês",
                            NTemporadas = 0,
                            Nome = "The Godfather",
                            Realizador = "Francis Ford Coppola",
                            Trailer = "https://www.youtube.com/watch?v=sY1S34973zA"
                        },
                        new
                        {
                            IdVideo = 2,
                            Ano = 2008,
                            Elenco = "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine",
                            Foto = "TheDarkKnight.jpg",
                            Genero = "Crime, Drama, Ação",
                            Idioma = "Inglês",
                            NTemporadas = 0,
                            Nome = "The dark Knight",
                            Realizador = "Christopher Nolan",
                            Trailer = "https://www.youtube.com/watch?v=EXeTwQWrcwY"
                        },
                        new
                        {
                            IdVideo = 3,
                            Ano = 2001,
                            Elenco = "Alan Howard, Noel Appleby, Sean Astin, Sala Baker",
                            Foto = "TheLordOfTheRings.jpg",
                            Genero = "Aventura, Fantasia, Drama",
                            Idioma = "Inglês",
                            NTemporadas = 0,
                            Nome = "The Lord of the Rings",
                            Realizador = "Peter Jackson",
                            Trailer = "https://www.youtube.com/watch?v=V75dMMIW2B4"
                        },
                        new
                        {
                            IdVideo = 4,
                            Ano = 1977,
                            Elenco = "Mark Hamill, Harrison Ford, Carrie Fisher, Peter Cushing",
                            Foto = "StarWars.jpg",
                            Genero = "Aventura, Ação, Fantasia",
                            Idioma = "Inglês",
                            NTemporadas = 0,
                            Nome = "Star Wars: Episode I",
                            Realizador = "George Lucas",
                            Trailer = "https://www.youtube.com/watch?v=bD7bpG-zDJQ"
                        },
                        new
                        {
                            IdVideo = 5,
                            Ano = 2001,
                            Elenco = "Daniel Radcliffe, Rupert Grint, Richard Harris",
                            Foto = "HarryPotter.jpg",
                            Genero = "Fantasia, Aventura, Família",
                            Idioma = "Inglês",
                            NTemporadas = 0,
                            Nome = "Harry Potter",
                            Realizador = "Chris Columbus",
                            Trailer = "https://www.youtube.com/watch?v=VyHV0BRtdxo"
                        },
                        new
                        {
                            IdVideo = 6,
                            Ano = 2008,
                            Elenco = "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris",
                            Foto = "BreakingBad.jpg",
                            Genero = "Drama, Crime, Thriller",
                            Idioma = "Inglês",
                            NTemporadas = 5,
                            Nome = "Breaking Bad",
                            Realizador = "Vince Gilligan",
                            Trailer = "https://www.youtube.com/watch?v=HhesaQXLuRY"
                        },
                        new
                        {
                            IdVideo = 7,
                            Ano = 2011,
                            Elenco = " Emilia Clarke, Peter Dinklage, Lena Headey, Peter Dinklage, Kit Harington",
                            Foto = "GameOfThrones.jpg",
                            Genero = "Aventura, Drama, Fantasia",
                            Idioma = "Inglês",
                            NTemporadas = 8,
                            Nome = "Game of Thrones",
                            Realizador = "D.B. Weiss, David Benioff",
                            Trailer = "https://www.youtube.com/watch?v=gcTkNV5Vg1E"
                        },
                        new
                        {
                            IdVideo = 8,
                            Ano = 2013,
                            Elenco = "Justin Roiland, Chris Parnell, Spencer Grammer, Sarah Chalke",
                            Foto = "RickMorty.jpg",
                            Genero = "Animação, Aventura, Comédia",
                            Idioma = "Inglês",
                            NTemporadas = 4,
                            Nome = "Rick and Morty",
                            Realizador = "Dan Harmon, Justin Roiland",
                            Trailer = "https://www.youtube.com/watch?v=Uz2m4T_JNIs"
                        },
                        new
                        {
                            IdVideo = 9,
                            Ano = 2020,
                            Elenco = "Justin Roiland, Sean Giambrone, Thomas Middleditch",
                            Foto = "solarOpposites.jpg",
                            Genero = "Animação, Faroeste, Ficção Científica",
                            Idioma = "Inglês",
                            NTemporadas = 2,
                            Nome = "Solar Opposites",
                            Realizador = "Justin Roiland, Mike McMahan",
                            Trailer = "https://www.youtube.com/watch?v=UN7OH4d3CEw"
                        },
                        new
                        {
                            IdVideo = 10,
                            Ano = 2018,
                            Elenco = "Olan Rogers, Fred Armisen, David Tennant",
                            Foto = "FinalSpace.jpg",
                            Genero = "Animação, Aventura, Comédia",
                            Idioma = "Inglês",
                            NTemporadas = 3,
                            Nome = "Final Space",
                            Realizador = "Olan Rogers",
                            Trailer = "https://www.youtube.com/watch?v=fkyNpNysdZw"
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
                    b.HasOne("Watch2Chill.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Watch2Chill.Data.ApplicationUser", null)
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

                    b.HasOne("Watch2Chill.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Watch2Chill.Data.ApplicationUser", null)
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
                    b.HasOne("Watch2Chill.Models.Videos", "Video")
                        .WithMany("ListaDeTemporadas")
                        .HasForeignKey("IdVideosFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Video");
                });

            modelBuilder.Entity("Watch2Chill.Models.UtilizadoresVideos", b =>
                {
                    b.HasOne("Watch2Chill.Models.Utilizadores", "Utilizador")
                        .WithMany("ListaDeVideos")
                        .HasForeignKey("IdUtilizadorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Watch2Chill.Models.Videos", "Video")
                        .WithMany("ListaDeUtilizadores")
                        .HasForeignKey("IdVideoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilizador");

                    b.Navigation("Video");
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

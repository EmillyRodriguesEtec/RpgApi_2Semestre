﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgApi.Data;

#nullable disable

namespace RpgApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230807120426_MigracaoUmParaUm")]
    partial class MigracaoUmParaUm
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RpgApi.Models.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dano")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonagemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonagemId")
                        .IsUnique();

                    b.ToTable("Armas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dano = 35,
                            Nome = "Arco e Flecha",
                            PersonagemId = 1
                        },
                        new
                        {
                            Id = 2,
                            Dano = 33,
                            Nome = "Espada",
                            PersonagemId = 2
                        },
                        new
                        {
                            Id = 3,
                            Dano = 31,
                            Nome = "Machado",
                            PersonagemId = 3
                        },
                        new
                        {
                            Id = 4,
                            Dano = 30,
                            Nome = "Punho",
                            PersonagemId = 4
                        },
                        new
                        {
                            Id = 5,
                            Dano = 34,
                            Nome = "Chicote",
                            PersonagemId = 5
                        },
                        new
                        {
                            Id = 6,
                            Dano = 33,
                            Nome = "Foice",
                            PersonagemId = 6
                        },
                        new
                        {
                            Id = 7,
                            Dano = 32,
                            Nome = "Cajado",
                            PersonagemId = 7
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Disputa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AtacanteId")
                        .HasColumnType("int")
                        .HasColumnName("AtacanteId");

                    b.Property<DateTime?>("DataDisputa")
                        .HasColumnType("datetime2")
                        .HasColumnName("Dt_Disputa");

                    b.Property<string>("Narracao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tx_Narracao");

                    b.Property<int>("OponenteId")
                        .HasColumnType("int")
                        .HasColumnName("OponenteId");

                    b.HasKey("Id");

                    b.ToTable("TB_Disputas");
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Classe")
                        .HasColumnType("int");

                    b.Property<int>("Defesa")
                        .HasColumnType("int");

                    b.Property<int>("Forca")
                        .HasColumnType("int");

                    b.Property<byte[]>("FotoPersonagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Inteligencia")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontosVida")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Personagens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Classe = 1,
                            Defesa = 23,
                            Forca = 17,
                            Inteligencia = 33,
                            Nome = "Frodo",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 2,
                            Classe = 1,
                            Defesa = 25,
                            Forca = 15,
                            Inteligencia = 30,
                            Nome = "Sam",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 3,
                            Classe = 3,
                            Defesa = 21,
                            Forca = 18,
                            Inteligencia = 35,
                            Nome = "Galadriel",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 4,
                            Classe = 2,
                            Defesa = 18,
                            Forca = 18,
                            Inteligencia = 37,
                            Nome = "Gandalf",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 5,
                            Classe = 1,
                            Defesa = 17,
                            Forca = 20,
                            Inteligencia = 31,
                            Nome = "Hobbit",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 6,
                            Classe = 3,
                            Defesa = 13,
                            Forca = 21,
                            Inteligencia = 34,
                            Nome = "Celeborn",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 7,
                            Classe = 2,
                            Defesa = 11,
                            Forca = 25,
                            Inteligencia = 35,
                            Nome = "Radagast",
                            PontosVida = 100
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAcesso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Perfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Jogador");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "seuEmail@gmail.com",
                            Latitude = -23.520024100000001,
                            Longitude = -46.596497999999997,
                            PasswordHash = new byte[] { 77, 91, 143, 0, 80, 230, 144, 105, 52, 152, 112, 248, 189, 103, 204, 1, 119, 20, 184, 184, 159, 203, 48, 59, 193, 183, 190, 148, 212, 209, 11, 251, 33, 88, 132, 37, 74, 41, 98, 239, 115, 251, 148, 100, 121, 73, 54, 112, 106, 57, 245, 207, 139, 20, 63, 100, 70, 238, 220, 192, 19, 133, 191, 144 },
                            PasswordSalt = new byte[] { 97, 3, 35, 218, 77, 197, 107, 57, 154, 138, 232, 63, 127, 255, 75, 66, 229, 250, 113, 71, 240, 172, 147, 85, 199, 29, 92, 195, 61, 219, 102, 186, 97, 144, 100, 177, 223, 180, 248, 10, 64, 114, 230, 181, 84, 245, 252, 124, 166, 152, 10, 104, 17, 106, 163, 35, 240, 198, 78, 132, 107, 62, 134, 174, 156, 17, 82, 49, 138, 50, 208, 215, 5, 1, 137, 2, 41, 161, 214, 167, 37, 31, 45, 96, 191, 1, 238, 72, 18, 58, 101, 156, 153, 97, 45, 172, 189, 145, 133, 249, 37, 78, 100, 59, 103, 193, 170, 65, 170, 123, 204, 29, 93, 226, 254, 69, 140, 0, 150, 33, 151, 144, 34, 254, 11, 191, 172, 222 },
                            Perfil = "Admin",
                            Username = "UsuarioAdmin"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Arma", b =>
                {
                    b.HasOne("RpgApi.Models.Personagem", "Personagem")
                        .WithOne("Arma")
                        .HasForeignKey("RpgApi.Models.Arma", "PersonagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personagem");
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.HasOne("RpgApi.Models.Usuario", "Usuario")
                        .WithMany("Personagens")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Navigation("Arma");
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Navigation("Personagens");
                });
#pragma warning restore 612, 618
        }
    }
}
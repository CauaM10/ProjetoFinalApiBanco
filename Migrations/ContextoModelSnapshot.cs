﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoFinalApi.Models;

#nullable disable

namespace ProjetoFinalApi.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoFinalApi.Models.Objeto", b =>
                {
                    b.Property<int>("ObjetoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObjetoId"));

                    b.Property<string>("ObjetoCor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoCor");

                    b.Property<DateTime>("ObjetoDtDesaparecimeto")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObjetoDtDesaparecimeto");

                    b.Property<DateTime?>("ObjetoDtEncontro")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObjetoDtEncontro");

                    b.Property<string>("ObjetoFoto")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoFoto");

                    b.Property<string>("ObjetoLocalDesaparecimeto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoLocalDesaparecimeto");

                    b.Property<string>("ObjetoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoNome");

                    b.Property<string>("ObjetoObservacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoObservacao");

                    b.Property<byte>("ObjetoStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("ObjetoStatus");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ObjetoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Objeto");
                });

            modelBuilder.Entity("ProjetoFinalApi.Models.Observacoes", b =>
                {
                    b.Property<int>("ObservacoesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ObservacoesId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObservacoesId"));

                    b.Property<int>("ObjetoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ObservacoesData")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObservacoesData");

                    b.Property<string>("ObservacoesDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacoesDescricao");

                    b.Property<string>("ObservacoesLocal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacoesLocal");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ObservacoesId");

                    b.HasIndex("ObjetoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Observacoes");
                });

            modelBuilder.Entity("ProjetoFinalApi.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNome");

                    b.Property<string>("UsuarioSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioSenha");

                    b.Property<string>("UsuarioTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioTelefone");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjetoFinalApi.Models.Objeto", b =>
                {
                    b.HasOne("ProjetoFinalApi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProjetoFinalApi.Models.Observacoes", b =>
                {
                    b.HasOne("ProjetoFinalApi.Models.Objeto", "Objeto")
                        .WithMany()
                        .HasForeignKey("ObjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoFinalApi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objeto");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}

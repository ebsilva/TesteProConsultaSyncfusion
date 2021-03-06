﻿// <auto-generated />
using System;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Core.Entities.Aso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Apto")
                        .HasColumnType("bit");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("FinsDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<int>("ModificadoPor")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("RealizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Rg")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Setor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Cpf");

                    b.HasIndex("MedicoId");

                    b.HasIndex("Rg");

                    b.ToTable("Asos");
                });

            modelBuilder.Entity("Core.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModificadoPor")
                        .HasColumnType("int");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeContato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoneContato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Core.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Core.Entities.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Crm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int>("ModificadoPor")
                        .HasColumnType("int");

                    b.Property<int>("Nome")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("Nome");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("Core.Entities.Risco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AsoId")
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModificadoPor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AsoId");

                    b.ToTable("Risco");
                });

            modelBuilder.Entity("Core.Entities.Aso", b =>
                {
                    b.HasOne("Core.Entities.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("Core.Entities.Medico", b =>
                {
                    b.HasOne("Core.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Core.Entities.Risco", b =>
                {
                    b.HasOne("Core.Entities.Aso", null)
                        .WithMany("Riscos")
                        .HasForeignKey("AsoId");
                });

            modelBuilder.Entity("Core.Entities.Aso", b =>
                {
                    b.Navigation("Riscos");
                });
#pragma warning restore 612, 618
        }
    }
}

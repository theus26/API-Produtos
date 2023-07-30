﻿// <auto-generated />
using System;
using API_Produtos.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Produtos.DAL.Migrations
{
    [DbContext(typeof(ProdutosContext))]
    partial class ProdutosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API_Produtos.DAL.Entities.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataUltimaVenda")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ValorUltimaVenda")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("qtde_estoque")
                        .HasColumnType("int");

                    b.Property<float>("valor_unitario")
                        .HasColumnType("float");

                    b.HasKey("IdProduto");

                    b.ToTable("produto");
                });
#pragma warning restore 612, 618
        }
    }
}

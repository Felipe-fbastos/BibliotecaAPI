﻿// <auto-generated />
using BibliotecaAPi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BibliotecaAPi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BibliotecaAPi.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_AUTOR");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "J.K. Rowling"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "George Orwell"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Jane Austen"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Mark Twain"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "F. Scott Fitzgerald"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Harper Lee"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Hemingway"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "J.R.R. Tolkien"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Gabriel García Márquez"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Oscar Wilde"
                        });
                });

            modelBuilder.Entity("BibliotecaAPi.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("QuantidadePaginas")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.Property<int>("idAutor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("idAutor");

                    b.ToTable("TB_LIVRO");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            QuantidadePaginas = 223,
                            Titulo = "Harry Potter e a Pedra Filosofal",
                            Valor = 49.899999999999999,
                            idAutor = 1
                        },
                        new
                        {
                            Id = 2,
                            QuantidadePaginas = 328,
                            Titulo = "1984",
                            Valor = 39.899999999999999,
                            idAutor = 2
                        },
                        new
                        {
                            Id = 3,
                            QuantidadePaginas = 368,
                            Titulo = "Orgulho e Preconceito",
                            Valor = 29.899999999999999,
                            idAutor = 3
                        },
                        new
                        {
                            Id = 4,
                            QuantidadePaginas = 366,
                            Titulo = "As Aventuras de Huckleberry Finn",
                            Valor = 32.899999999999999,
                            idAutor = 4
                        },
                        new
                        {
                            Id = 5,
                            QuantidadePaginas = 180,
                            Titulo = "O Grande Gatsby",
                            Valor = 25.899999999999999,
                            idAutor = 5
                        },
                        new
                        {
                            Id = 6,
                            QuantidadePaginas = 320,
                            Titulo = "O Sol é Para Todos",
                            Valor = 36.899999999999999,
                            idAutor = 6
                        },
                        new
                        {
                            Id = 7,
                            QuantidadePaginas = 128,
                            Titulo = "O Velho e o Mar",
                            Valor = 19.899999999999999,
                            idAutor = 7
                        },
                        new
                        {
                            Id = 8,
                            QuantidadePaginas = 310,
                            Titulo = "O Hobbit",
                            Valor = 44.899999999999999,
                            idAutor = 8
                        },
                        new
                        {
                            Id = 9,
                            QuantidadePaginas = 448,
                            Titulo = "Cem Anos de Solidão",
                            Valor = 59.899999999999999,
                            idAutor = 9
                        },
                        new
                        {
                            Id = 10,
                            QuantidadePaginas = 224,
                            Titulo = "O Retrato de Dorian Gray",
                            Valor = 39.899999999999999,
                            idAutor = 10
                        });
                });

            modelBuilder.Entity("BibliotecaAPi.Models.Livro", b =>
                {
                    b.HasOne("BibliotecaAPi.Models.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("idAutor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("BibliotecaAPi.Models.Autor", b =>
                {
                    b.Navigation("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}

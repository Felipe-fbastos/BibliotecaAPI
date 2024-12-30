using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaAPi.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Autor> TB_AUTOR { get; set;}
        public DbSet<Livro> TB_LIVRO { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Autor>().HasMany(li => li.Livros)
            .WithOne(au => au.Autor)
            .HasForeignKey(ai => ai.idAutor)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Autor>().HasData(
                new Autor { Id = 1, Nome = "J.K. Rowling" },
                new Autor { Id = 2, Nome = "George Orwell" },
                new Autor { Id = 3, Nome = "Jane Austen" },
                new Autor { Id = 4, Nome = "Mark Twain" },
                new Autor { Id = 5, Nome = "F. Scott Fitzgerald" },
                new Autor { Id = 6, Nome = "Harper Lee" },
                new Autor { Id = 7, Nome = "Hemingway" },
                new Autor { Id = 8, Nome = "J.R.R. Tolkien" },
                new Autor { Id = 9, Nome = "Gabriel García Márquez" },
                new Autor { Id = 10, Nome = "Oscar Wilde" }
            );

            // Seed de dados para Livro (usando livros reais)
            modelBuilder.Entity<Livro>().HasData(
                new Livro { Id = 1, Titulo = "Harry Potter e a Pedra Filosofal", QuantidadePaginas = 223, Valor = 49.90, idAutor = 1 },
                new Livro { Id = 2, Titulo = "1984", QuantidadePaginas = 328, Valor = 39.90, idAutor = 2 },
                new Livro { Id = 3, Titulo = "Orgulho e Preconceito", QuantidadePaginas = 368, Valor = 29.90, idAutor = 3 },
                new Livro { Id = 4, Titulo = "As Aventuras de Huckleberry Finn", QuantidadePaginas = 366, Valor = 32.90, idAutor = 4 },
                new Livro { Id = 5, Titulo = "O Grande Gatsby", QuantidadePaginas = 180, Valor = 25.90, idAutor = 5 },
                new Livro { Id = 6, Titulo = "O Sol é Para Todos", QuantidadePaginas = 320, Valor = 36.90, idAutor = 6 },
                new Livro { Id = 7, Titulo = "O Velho e o Mar", QuantidadePaginas = 128, Valor = 19.90, idAutor = 7 },
                new Livro { Id = 8, Titulo = "O Hobbit", QuantidadePaginas = 310, Valor = 44.90, idAutor = 8 },
                new Livro { Id = 9, Titulo = "Cem Anos de Solidão", QuantidadePaginas = 448, Valor = 59.90, idAutor = 9 },
                new Livro { Id = 10, Titulo = "O Retrato de Dorian Gray", QuantidadePaginas = 224, Valor = 39.90, idAutor= 10 }
            );
        }
    }



}
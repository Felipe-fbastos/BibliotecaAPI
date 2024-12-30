using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BibliotecaAPi.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int QuantidadePaginas { get; set; }
        public double Valor { get; set; }
        public int idAutor { get; set; }
        
        [JsonIgnore]
        public Autor Autor { get; set; }


    }
}
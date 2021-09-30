using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace provaLivro.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int? Paginas { get; set; }
        public string Editora { get; set; }
        public string Descricao { get; set; }
        public string ISBN { get; set; }

    
        
        public override string ToString() =>
            $"Titulo: {Titulo} || Autor: {Autor} || Paginas: {Paginas} || Editora: {Editora} || Descricao: {Descricao} || ISBN: {ISBN}";
    }
}
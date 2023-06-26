using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProjeto23.Models
{
    public class Produto
    {
        public long? ProdutoId { get; set; }
        public string Nome { get; set; }
        public long? CategoriaId { get; set; }
        public long? FabricanteId { get; set; }
        public string LogotipoMimeType { get; set; }
        public byte[] Logotipo { get; set; }
        public string NomeArquivo { get; set; }
        public long TamanhoArquivo { get; set; }
        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}